namespace SEMaster.FileFormats
{
	public class Zip_DirectoryEntry
	{
		public uint Signature { get; set; }
		public ushort VersionMadeBy { get; set; }
		public ushort VersionNeededToExtract { get; set; }
		public ushort Flags { get; set; }
		public ushort CompressionMethod { get; set; }
		public ushort LastModifiedTime { get; set; }
		public ushort LastModifiedDate { get; set; }
		public uint Checksum { get; set; }
		public uint CompressedSize { get; set; }
		public uint UncompressedSize { get; set; }
		public ushort FileNameLength { get; set; }
		public ushort ExtraFieldLength { get; set; }
		public ushort FileCommentLength { get; set; }
		public ushort DiskNumberStart { get; set; }
		public ushort PublicFileAttribs { get; set; }
		public uint ExternalFileAttribs { get; set; }
		public uint RelativeOffsetOfLocalHeader { get; set; }
		public string? FileName { get; set; }
	}
}
