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

# Programing Assignment 2

I will have to calculate the velocity vector based on some coordinates using the pythagorean theorem, which states:

$c^2 = a^2 + b^2$

If I take the square root of $a^2 + b^2$ I get $c$

It was easy to do this, the only problem I had was with type casting (bad habits from Python). The solution is detailed below:

```cs
// First just calculate the squared delta from the X and Y coordinates
float squaredDeltaX = (float)Math.Pow((point2X-point1X),2);
float squaredDeltaY = (float)Math.Pow((point2Y-point1Y),2);

// Then calculate the distance using the pythagorean theorem 
float distance = (float)Math.Sqrt(squaredDeltaY+squaredDeltaX);

// Then calculate the angle (in radians) using Atan2 
float radians  = (float)Math.Atan2((point2Y-point1Y), (point2X-point1X));

// Convert radians to degrees
float degreesFromRadians = radians * (float)(180 / Math.PI);

// Print the result the way the instruction says (distance -> single space -> angle)
Console.WriteLine(distance + " " + degreesFromRadians);
```