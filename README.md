# Quick Wake-On-LAN App
![Icon](icon/wol-green.ico)

## building
Before building, change the MAC in the source code (`wol.cs`).

```
    public static string MAC = "00:01:a2:a3:04:05";
    // put your MAC here:       ^^^^^^^^^^^^^^^^^
```

Following notations are supported:
* `0001a2a30405`
* `0001A2A30405`
* `00:01:a2:a3:04:05`
* `00:01:A2:A3:04:05`
* `00-01-a2-a3-04-05`
* `00-01-A2-A3-04-05`

### Windows

Requires `csc.exe` which is shipped with `Microsoft.NET` runtimes. No Visual Studio required.

```
X:\dev\wol> build-win.bat
```

Or just double click the `build-win.bat` file.

Tested with:
* `v4.0.30319` (default)
* `v3.5`
* `v2.0.50727`

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
