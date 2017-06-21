# Quick Wake-On-LAN App
![Icon](icon/wol-green.ico)

## building
Before building, change the MAC in a source code (`wol.cs`).

```
static readonly byte[] MAC = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
// your MAC here:                ^^    ^^    ^^    ^^    ^^    ^^
```

### Windows

Requires `csc.exe` which is shipped with `Microsoft.NET` runtimes. No Visual Studio required.

```
X:\dev\wol> build-win.bat
```

(Defaults to `v4.0.30319` release, but this can be changed in the build script.)

### Linux

Requires `mcs` compiler. (`mono-mcs` in Ubuntu)

```
$ ./build-mono.sh
```

## running
### Windows

Just double click the `wol.exe` file.

### Linux

```
$ mono wol.exe
or
$ ./wol.exe
```

## icon
The application comes with a set of colorful high-resolution icons. Alter the ICON variable in a build script to use the icon of your choice.

## FAQ
1. **Why is the MAC hard-coded (compile time option) instead of being a parameter?**

This is a really simple tool that one can use to create dedicated executables for specific machines.
It comes with no run-time options, no dialogs, no parameters, no config files, no registry. It's not a bug, it's a feature.

Feel free to fork the project and extend the tool in any way you want.
