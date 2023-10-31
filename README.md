# Setting up environment

## My OS for reference

```
             /////////////                fornav@pop-os 
         /////////////////////            ------------- 
      ///////*767////////////////         OS: Pop!_OS 22.04 LTS x86_64 
    //////7676767676*//////////////       Host: Inspiron 5502 
   /////76767//7676767//////////////      Kernel: 6.5.6-76060506-generic 
  /////767676///*76767///////////////     Uptime: 6 mins 
 ///////767676///76767.///7676*///////    Packages: 2406 (dpkg), 32 (flatpak) 
/////////767676//76767///767676////////   Shell: bash 5.1.16 
//////////76767676767////76767/////////   Resolution: 1920x1080, 3840x2160 
///////////76767676//////7676//////////   DE: GNOME 42.5 
////////////,7676,///////767///////////   WM: Mutter 
/////////////*7676///////76////////////   WM Theme: Pop 
///////////////7676////////////////////   Theme: Pop-dark [GTK2/3] 
 ///////////////7676///767////////////    Icons: Pop [GTK2/3] 
  //////////////////////'////////////     Terminal: gnome-terminal 
   //////.7676767676767676767,//////      CPU: 11th Gen Intel i7-1165G7 (8) @ 4 
    /////767676767676767676767/////       GPU: NVIDIA GeForce MX350 
      ///////////////////////////         GPU: Intel TigerLake-LP GT2 [Iris Xe  
         /////////////////////            Memory: 4361MiB / 15712MiB 
             /////////////
```

1. Add repo:

```bash
sudo sh -c 'echo "deb https://hub.unity3d.com/linux/repos/deb stable main" > /etc/apt/sources.list.d/unityhub.list'
```

2. Add public key:

```bash
wget -qO - https://hub.unity3d.com/linux/keys/public | sudo apt-key add -
```

3. Update and install Unity:

```bash
sudo apt update
sudo apt-get install unityhub
```

4. Install Unity extension to VS (will install C# extensions as well)

5. Download .NET SDK install script:

```bash
wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
```

6. Change the script permission:

```bash
chmod +x ./dotnet-install.sh
```

7. Install .NET SDK:

```bash
./dotnet-install.sh --channel 7.0
```

8. Add .NET path to bashrc file:

```bash
# DOTNET path
export DOTNET_ROOT=$HOME/.dotnet
export PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools
```

9. To ensure .NET is correctly installed and that VS-Code can see it, reboot your machine and then open VS-Code

10. Inside VS-Code open the terminal, then open a folder with, create and run a C# code file (F5 ou Fn+F5). In the output tab you should see the following:

```
Using dotnet configured on PATH
Dotnet path: /home/fornav/.dotnet/dotnet
Activating C# standalone...
waiting for named pipe information from server...
[stdout] {"pipeName":"/tmp/b8b43f34-fcd1-4eb3-92ea-c60d614a8799.sock"}
received named pipe information from server
attempting to connect client to server...
client has connected to server
[Info  - 10:52:25 PM] [Program] Language server initialized
```

Installing mono (if you want):

```bash
sudo apt install gnupg ca-certificates

sudo apt-key adv –keyserver hkp://keyserver.ubuntu.com:80 –recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF

echo deb https://download.mono-project.com/repo/ubuntu stable-focal main | sudo tee /etc/apt/sources.list.d/mono-official-stable.list

sudo apt update
```

```bash
sudo apt install mono-complete
```

To use mono to compile and run C#, we will need to do some stuff:

1. Allow `.cs` file to be executable:

```bash
sudo chmod +x code_file.cs
```

2. To compile into `.exe`:

```bash
mcs -out:code_file.exe code_file.cs
```

3. To run it:

```bash
mono code_file.exe
```

The recommended way to run C# code will be via C# Dev Kit inside VS-Code or inside Unity while running a project.

## This repo

This repository contains my personal studies about C# and Unity game development. I have divided every exercise and Unity project in two folders each: public and private. Private folders wont be pushed to this public repository (see `.gitignore`).