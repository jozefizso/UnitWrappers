using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using MS.Internal.PresentationCore;

namespace UnitWrappers.System.Windows
{

    public class ClipboardWrap : IClipboard
    {

        [SecurityCritical]
        public void Clear()
        {
            Clipboard.Clear();
        }


        public bool ContainsAudio()
        {
          return  Clipboard.ContainsAudio();
        }

        public bool ContainsData(string format)
        {
            return Clipboard.ContainsData(format);
        }

        public bool ContainsFileDropList()
        {
            return Clipboard.ContainsFileDropList();
        }

        public bool ContainsImage()
        {
            return Clipboard.ContainsImage();
        }

        public bool ContainsText()
        {
            return Clipboard.ContainsText();
        }

        public bool ContainsText(TextDataFormat format)
        {
            return Clipboard.ContainsText(format);
        }

        public Stream GetAudioStream()
        {
            return Clipboard.GetAudioStream();
        }

        public object GetData(string format)
        {
            return Clipboard.GetData(format);
        }

        public StringCollection GetFileDropList()
        {
            return Clipboard.GetFileDropList();
        }

        public BitmapSource GetImage()
        {
            return Clipboard.GetImage();
        }

        #if NET40
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        #endif        
        public string GetText()
        {
            return Clipboard.GetText();
        }

        public string GetText(TextDataFormat format)
        {
            return Clipboard.GetText(format);
        }

        public void SetAudio(byte[] audioBytes)
        {
            Clipboard.SetAudio(audioBytes);
        }

        public void SetAudio(Stream audioStream)
        {
            Clipboard.SetAudio(audioStream);
        }

        public void SetData(string format, object data)
        {
            Clipboard.SetData(format,data);
        }

        public void SetFileDropList(StringCollection fileDropList)
        {
            Clipboard.SetFileDropList(fileDropList);
        }

        public void SetImage(BitmapSource image)
        {
            Clipboard.SetImage(image);
        }

        public void SetText(string text)
        {
            Clipboard.SetText(text);
        }

        public void SetText(string text, TextDataFormat format)
        {
            Clipboard.SetText(text,format);
        }

        [SecurityCritical]
        public IDataObject GetDataObject()
        {
           return Clipboard.GetDataObject();
        }

        public bool IsCurrent(IDataObject data)
        {
            return Clipboard.IsCurrent(data);
        }

        [SecurityCritical]
        public void SetDataObject(object data)
        {
            Clipboard.SetDataObject(data);
        }

        [SecurityCritical]
        public void SetDataObject(object data, bool copy)
        {
            Clipboard.SetDataObject(data,copy);
        }
    }
}
