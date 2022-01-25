namespace de4dot_gui
{
    public struct ProcessSettings
    {
        public bool ForceObfuscator { get; }
        public int EnumIndex { get; }
        
        public bool NoRenaming { get; }
        
        public StringDecryptionSettings DecryptionSettings { get; }             

        public ProcessSettings(bool forceObfuscator, int enumIndex, bool noRenaming, StringDecryptionSettings decryptionSettings)
        {
            ForceObfuscator = forceObfuscator;
            EnumIndex = enumIndex;
            NoRenaming = noRenaming;
            DecryptionSettings = decryptionSettings;
        }
    }

    public readonly struct StringDecryptionSettings
    {
        public string[] Elements { get; }
        
        public int MethodId { get; }

        public StringDecryptionSettings( int methodId, string[] elements )
        {
            MethodId = methodId;
            Elements = elements;
        }
    }
}