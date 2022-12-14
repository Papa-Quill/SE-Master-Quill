namespace SEMaster.FileFormats
{
	public class ZIP_EndOfCentralDirRecord
	{
		public const uint SIGNATURE = 0x6054b50;
		public uint Signature { get; set; }
		public ushort ZipNumber { get; set; }
		public ushort MasterZipNumber { get; set; }
		public ushort DirectoryCount { get; set; }
		public ushort DirectoryCountTotal { get; set; }
		public uint DirectorySize { get; set; }
		public uint DirectoryOffset { get; set; }
		public ushort CommentLength { get; set; }
		public string? Comment { get; set; }
	}
}
