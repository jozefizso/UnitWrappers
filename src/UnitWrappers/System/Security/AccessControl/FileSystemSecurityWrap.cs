using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.AccessControl;
using System.Security.Principal;

namespace UnitWrappers.System.Security.AccessControl
{
    public class FileSystemSecurityWrap : IFileSystemSecurity,IWrap<FileSystemSecurity>
    {
        private FileSystemSecurity _underlyingObject;
        FileSystemSecurity IWrap<FileSystemSecurity>.UnderlyingObject
        {
            get { return _underlyingObject; }
        }

        public static implicit operator FileSystemSecurityWrap(FileSystemSecurity o)
        {
            return new FileSystemSecurityWrap(o);
        }

        public static implicit operator FileSystemSecurity(FileSystemSecurityWrap o)
        {
            return o._underlyingObject;
        }

        public FileSystemSecurityWrap(FileSystemSecurity underlyingObject)
        {
            _underlyingObject = underlyingObject;
        }

        public Type AccessRightType
        {
            get { throw new NotImplementedException(); }
        }

        public Type AccessRuleType
        {
            get { throw new NotImplementedException(); }
        }

        public Type AuditRuleType
        {
            get { throw new NotImplementedException(); }
        }

        public AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
        {
            throw new NotImplementedException();
        }

        public AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
        {
            throw new NotImplementedException();
        }

        public void AddAccessRule(FileSystemAccessRule rule)
        {
            throw new NotImplementedException();
        }

        public void SetAccessRule(FileSystemAccessRule rule)
        {
            throw new NotImplementedException();
        }

        public void ResetAccessRule(FileSystemAccessRule rule)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAccessRule(FileSystemAccessRule rule)
        {
            throw new NotImplementedException();
        }

        public void RemoveAccessRuleAll(FileSystemAccessRule rule)
        {
            throw new NotImplementedException();
        }

        public void RemoveAccessRuleSpecific(FileSystemAccessRule rule)
        {
            throw new NotImplementedException();
        }

        public void AddAuditRule(FileSystemAuditRule rule)
        {
            throw new NotImplementedException();
        }

        public void SetAuditRule(FileSystemAuditRule rule)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAuditRule(FileSystemAuditRule rule)
        {
            throw new NotImplementedException();
        }

        public void RemoveAuditRuleAll(FileSystemAuditRule rule)
        {
            throw new NotImplementedException();
        }

        public void RemoveAuditRuleSpecific(FileSystemAuditRule rule)
        {
            throw new NotImplementedException();
        }
    }
}
