using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Collections;

namespace KuzaNetObfuscator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            text_newname.Text = RandomString(9);
            box_numberofjunk.Text = RandomNumber(3);
        }

        
        private void checkjunk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkstrings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkname_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Executables | *.*";
            openfiledialog.ShowDialog();
            box_file.Text = openfiledialog.FileName;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            try {
                AssemblyDef assembly = AssemblyDef.Load(box_file.Text);
                ModuleContext modCtx = ModuleDefMD.CreateModuleContext();
                ModuleDefMD module = ModuleDefMD.Load(box_file.Text, modCtx);
                if (checkname.Checked)
                {
                    ProtectName(assembly, module);
                    module.Write(text_newname.Text + ".exe");
                }
                if (checkjunk.Checked)
                {
                    junkattrib(module);
                    module.Write(text_newname.Text + ".exe");
                }
                if (checkstrings.Checked)
                {
                    encryptString(module);
                    module.Write(text_newname.Text + ".exe");
                }
                MessageBox.Show("Done!! ", "KuzaNetObfuscator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                restart();
            }
            catch
            {
                MessageBox.Show("Something went wrong, maybe no file selected? ", "KuzaNetObfuscator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void restart()
        {
            text_newname.Text = RandomString(9);
            box_numberofjunk.Text = RandomNumber(3);
        }

        public void ProtectName(AssemblyDef assembly, ModuleDef mod)
        {
            
            foreach (TypeDef type in mod.Types)
            {
                mod.Name = "kuzaNetObf";
                if (type.IsGlobalModuleType || type.IsRuntimeSpecialName || type.IsSpecialName || type.IsWindowsRuntime || type.IsInterface)
                {
                    continue;
                }
                else
                {
                    foreach (PropertyDef property in type.Properties)
                    {
                        if (property.IsRuntimeSpecialName) continue;
                        property.Name = RandomString(20) + "beep bap";
                    }
                    foreach (FieldDef fields in type.Fields)
                    {
                        fields.Name = RandomString(20) + "ass";
                    }
                    foreach (EventDef eventdef in type.Events)
                    {
                        eventdef.Name = RandomString(20) + "fuck";
                    }
                    foreach (MethodDef method in type.Methods)
                    {
                        if (method.IsConstructor || method.IsRuntimeSpecialName || method.IsRuntime || method.IsStaticConstructor || method.IsVirtual) continue;
                        method.Name = RandomString(20);
                    }
                }
            }
        }

        //random string
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomNumber(int length)
        {
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //junk
        public void junkattrib(ModuleDefMD module)
        {
            int number = System.Convert.ToInt32(box_numberofjunk.Text);
            for (int i = 0; i < number; i++)
            {
                var junkattribute = new TypeDefUser("fuck" + RandomString(20), "ass" + RandomString(20), module.CorLibTypes.Object.TypeDefOrRef);
                module.Types.Add(junkattribute);
            }
        }
        //strings
        public void encryptString(ModuleDef module)
        {
            foreach (TypeDef type in module.Types)
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (method.Body == null) continue;
                    method.Body.SimplifyBranches();
                    for (int i = 0; i < method.Body.Instructions.Count; i++)
                    {
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                        {
                            string base64toencrypt = method.Body.Instructions[i].Operand.ToString();
                            string base64EncryptedString = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(base64toencrypt));
                            method.Body.Instructions[i].OpCode = OpCodes.Nop;
                            method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, module.Import(typeof(System.Text.Encoding).GetMethod("get_UTF8", new Type[] { }))));
                            method.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Ldstr, base64EncryptedString));
                            method.Body.Instructions.Insert(i + 3, new Instruction(OpCodes.Call, module.Import(typeof(System.Convert).GetMethod("FromBase64String", new Type[] { typeof(string) }))));
                            method.Body.Instructions.Insert(i + 4, new Instruction(OpCodes.Callvirt, module.Import(typeof(System.Text.Encoding).GetMethod("GetString", new Type[] { typeof(byte[]) }))));
                            i += 4;
                        }
                    }
                }
            }
        }

        private void box_file_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void box_file_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; 
            if (files != null && files.Any())
                box_file.Text = files.First();
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any())
                box_file.Text = files.First();
        }

        private void Main_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
