using Gibbed.IO;

namespace SEMaster.FileFormats
{
	public class XZP2Pack
	{
		private Stream _zipStream;
		private ZIP_EndOfCentralDirRecord? _zipEOF;

		/// <summary>
		/// Directory of the zip in dictionary format (relative zip path, directory entry)
		/// </summary>
		public Dictionary<string, Zip_DirectoryEntry> ZipEntries { get; set; }

		public XZP2Pack(Stream zipStream)
		{
			_zipStream = zipStream;
			ZipEntries = new Dictionary<string, Zip_DirectoryEntry>();
			OpenZip();
		}

		public byte[] ExtractFile(string fileName)
		{
			throw new NotImplementedException();
		}

		private void OpenZip()
		{
			// read EOF, since the zip is aligned to 0x800 bytes,
			// the eof is located at -0x36 bytes from the end
			_zipStream.Seek(-0x36, SeekOrigin.End);

			// read in eof
			_zipEOF = new ZIP_EndOfCentralDirRecord
			{
				Signature = _zipStream.ReadValueU32(),
				ZipNumber = _zipStream.ReadValueU16(),
				MasterZipNumber = _zipStream.ReadValueU16(),
				DirectoryCount = _zipStream.ReadValueU16(),
				DirectoryCountTotal = _zipStream.ReadValueU16(),
				DirectorySize = _zipStream.ReadValueU32(),
				DirectoryOffset = _zipStream.ReadValueU32(),
				CommentLength = _zipStream.ReadValueU16()
			};
			_zipEOF.Comment = _zipStream.ReadString(_zipEOF.CommentLength);

			// read zip directory
			_zipStream.Seek(_zipEOF.DirectoryOffset, SeekOrigin.Begin);
			for (int i = 0; i < _zipEOF.DirectoryCount; i++)
			{
				var curEntry = new Zip_DirectoryEntry
				{
					Signature = _zipStream.ReadValueU32(),
					VersionMadeBy = _zipStream.ReadValueU16(),
					VersionNeededToExtract = _zipStream.ReadValueU16(),
					Flags = _zipStream.ReadValueU16(),
					CompressionMethod = _zipStream.ReadValueU16(),
					LastModifiedTime = _zipStream.ReadValueU16(),
					LastModifiedDate = _zipStream.ReadValueU16(),
					Checksum = _zipStream.ReadValueU32(),
					CompressedSize = _zipStream.ReadValueU32(),
					UncompressedSize = _zipStream.ReadValueU32(),
					FileNameLength = _zipStream.ReadValueU16(),
					ExtraFieldLength = _zipStream.ReadValueU16(),
					FileCommentLength = _zipStream.ReadValueU16(),
					DiskNumberStart = _zipStream.ReadValueU16(),
					PublicFileAttribs = _zipStream.ReadValueU16(),
					ExternalFileAttribs = _zipStream.ReadValueU32(),
					RelativeOffsetOfLocalHeader = _zipStream.ReadValueU32()
				};
				curEntry.FileName = _zipStream.ReadString(curEntry.FileNameLength);

				ZipEntries.Add(curEntry.FileName, curEntry);
			}
		}
	}
}
