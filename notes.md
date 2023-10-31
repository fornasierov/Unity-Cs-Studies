# Creating a new project in Unity

1. In the Unity UI, we can go to the `Projects` tab
2. Click the "New project" button
3. We will create 2D games for now. Click on "2D Core"
4. Name the project
5. Set the project location
6. Once the Unity project is open, right-click the "Assets" tab in the "Project" section of the UI and create a new folder for scripts called "Scripts"
7. To change the external script editor in Unity, you will need to open `Edit -> Preferences -> External tools` and then in "External Script Editor", locate your editor executable binary file. In my case I'm using VSCODE installed as a Flatpak, so I had to locate the binary file running:

```
flatpak info --show-location com.visualstudio.code
```