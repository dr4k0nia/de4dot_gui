using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace de4dot_gui
{
    public class Processor
    {
        private readonly string _filepath;
        private readonly bool _use64Bit;

        public Processor(string filepath, bool use64Bit)
        {
            _filepath = filepath;
            _use64Bit = use64Bit;
        }

        public void Execute(ProcessSettings settings)
        {
            string arguments = ConstructArguments(settings);

            string executablePath =
                _use64Bit ? Properties.Settings.Default.deobfPath64 : Properties.Settings.Default.deobfPath;

            if (!File.Exists(executablePath))
            {
                Helper.ShowError($"Could not find {executablePath} aborting deobfuscation process");
                return;
            }

            Process.Start(
                executablePath,
                arguments);
        }

        private string ConstructArguments(ProcessSettings settings)
        {
            var args = new StringBuilder($"{_filepath} ");

            if (settings.ForceObfuscator)
            {
                string? obfuscator = GetObfuscator(settings.EnumIndex);
                if (obfuscator != null)
                    args.Append($"-p {obfuscator} ");
            }

            if (settings.NoRenaming)
                args.Append("--dont-rename ");

            string? decryptionMethod = GetDecryptionMethod(settings.DecryptionSettings.MethodId);

            if (decryptionMethod == null) 
                return args.ToString();

            if (settings.DecryptionSettings.Elements.Length == 0)
                return args.ToString();
            
            args.Append($"--strtyp {decryptionMethod} ");

            foreach (string token in settings.DecryptionSettings.Elements)
            {
                args.Append($"--strtok {token} ");
            }

            return args.ToString();
        }

        private static string? GetObfuscator(int index)
        {
            return Enum.GetName(typeof(ObfuscatorTypes), index) ?? null;
        }

        private static string? GetDecryptionMethod(int id)
        {
            return id switch
            {
                0 => "delegate",
                1 => "emulate",
                _ => null
            };
        }
    }
}