

How to reflect to have wrappers generated?
---

1. Run CLR and reflect out.

2. Run reflector against DLL and IL.

In 1 we have to ensure that:

- reflecting code runs in all supported CLR 
- and we have all supported CLR versions running
- paths to references are given implicitly by system configuration

In 2:
- we have explicitly define paths to references assemblies
- and scan references manually, which is done by CLR when types are loaded


