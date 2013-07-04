using System.Collections.Specialized;
using System.IO;
using System.Runtime;
using System.Security;
using System.Windows;
using System.Windows.Media.Imaging;

namespace UnitWrappers.System.Windows
{
    /// <summary>
    /// Provides methods that facilitate transferring data to and from the system Clipboard.
    /// </summary>
    public interface IClipboard
    {
        /// <summary>
        /// Clears any data from the system Clipboard.
        /// </summary>
        [SecurityCritical]
        void Clear();

        bool ContainsAudio();
        bool ContainsData(string format);
        bool ContainsFileDropList();
        bool ContainsImage();
        bool ContainsText();
        bool ContainsText(TextDataFormat format);
        Stream GetAudioStream();
        object GetData(string format);
        StringCollection GetFileDropList();
        BitmapSource GetImage();

#if NET40
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
#endif
        string GetText();

        string GetText(TextDataFormat format);
        void SetAudio(byte[] audioBytes);
        void SetAudio(Stream audioStream);
        void SetData(string format, object data);
        void SetFileDropList(StringCollection fileDropList);
        void SetImage(BitmapSource image);
        void SetText(string text);
        void SetText(string text, TextDataFormat format);

        [SecurityCritical]
        IDataObject GetDataObject();

        bool IsCurrent(IDataObject data);

        [SecurityCritical]
        void SetDataObject(object data);

        [SecurityCritical]
        void SetDataObject(object data, bool copy);
    }
}