using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UnitWrappers.System.Diagnostics
{
    public class FileVersionInfoWrap : IFileVersionInfo, IWrap<FileVersionInfo>
    {
        private FileVersionInfo _underlyingObject;

        public static implicit operator FileVersionInfoWrap(FileVersionInfo o)
        {
            return new FileVersionInfoWrap(o);
        }

        public static implicit operator FileVersionInfo(FileVersionInfoWrap o)
        {
            return o._underlyingObject;
        }

        public FileVersionInfoWrap(FileVersionInfo underlyingObject)
        {
            _underlyingObject = underlyingObject;
        }

        FileVersionInfo IWrap<FileVersionInfo>.UnderlyingObject { get { return _underlyingObject; } }

        /// <summary>
        /// Returns a partial list of properties in the <see cref="T:System.Diagnostics.FileVersionInfo"/> and their values.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A list of the following properties in this class and their values:
        ///                 <see cref="P:System.Diagnostics.FileVersionInfo.FileName"/>, <see cref="P:System.Diagnostics.FileVersionInfo.InternalName"/>, <see cref="P:System.Diagnostics.FileVersionInfo.OriginalFilename"/>, <see cref="P:System.Diagnostics.FileVersionInfo.FileVersion"/>, <see cref="P:System.Diagnostics.FileVersionInfo.FileDescription"/>, <see cref="P:System.Diagnostics.FileVersionInfo.ProductName"/>, <see cref="P:System.Diagnostics.FileVersionInfo.ProductVersion"/>, <see cref="P:System.Diagnostics.FileVersionInfo.IsDebug"/>, <see cref="P:System.Diagnostics.FileVersionInfo.IsPatched"/>, <see cref="P:System.Diagnostics.FileVersionInfo.IsPreRelease"/>, <see cref="P:System.Diagnostics.FileVersionInfo.IsPrivateBuild"/>, <see cref="P:System.Diagnostics.FileVersionInfo.IsSpecialBuild"/>,
        ///                 <see cref="P:System.Diagnostics.FileVersionInfo.Language"/>.
        /// 
        ///                     If the file did not contain version information, this list will contain only the name of the requested file. Boolean values will be false, and all other entries will be null.
        /// 
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return _underlyingObject.ToString();
        }

        public string Comments { get { return _underlyingObject.Comments; } }
        public string CompanyName { get { return _underlyingObject.CompanyName; } }
        public int FileBuildPart { get { return _underlyingObject.FileBuildPart; } }
        public string FileDescription { get { return _underlyingObject.FileDescription; } }
        public int FileMajorPart { get { return _underlyingObject.FileMajorPart; } }
        public int FileMinorPart { get { return _underlyingObject.FileMinorPart; } }
        public string FileName { get { return _underlyingObject.FileName; } }
        public int FilePrivatePart { get { return _underlyingObject.FilePrivatePart; } }
        public string FileVersion { get { return _underlyingObject.FileVersion; } }
        public string InternalName { get { return _underlyingObject.InternalName; } }
        public bool IsDebug { get { return _underlyingObject.IsDebug; } }
        public bool IsPatched { get { return _underlyingObject.IsPatched; } }
        public bool IsPrivateBuild { get { return _underlyingObject.IsPrivateBuild; } }
        public bool IsPreRelease { get { return _underlyingObject.IsPreRelease; } }
        public bool IsSpecialBuild { get { return _underlyingObject.IsSpecialBuild; } }
        public string Language { get { return _underlyingObject.Language; } }
        public string LegalCopyright { get { return _underlyingObject.LegalCopyright; } }
        public string LegalTrademarks { get { return _underlyingObject.LegalTrademarks; } }
        public string OriginalFilename { get { return _underlyingObject.OriginalFilename; } }
        public string PrivateBuild { get { return _underlyingObject.PrivateBuild; } }
        public int ProductBuildPart { get { return _underlyingObject.ProductBuildPart; } }
        public int ProductMajorPart { get { return _underlyingObject.ProductMajorPart; } }
        public int ProductMinorPart { get { return _underlyingObject.ProductMinorPart; } }
        public string ProductName { get { return _underlyingObject.ProductName; } }
        public int ProductPrivatePart { get { return _underlyingObject.ProductPrivatePart; } }
        public string ProductVersion { get { return _underlyingObject.ProductVersion; } }
        public string SpecialBuild { get { return _underlyingObject.SpecialBuild; } }
    }
}
