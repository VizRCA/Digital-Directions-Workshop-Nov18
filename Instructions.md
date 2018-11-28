# A game-art introduction to unity
## Contents

+ [x] [Basics](#basics)
+ [x] [Physics Simulation](#physics-simulation)
+ [x] [Navigating space](#navigating-space)
+ [x] [Sound](#sound)
+ [x] [Terrain](#terrain) 
+ [x] [Scripts](#scripts) 
+ [x] [Interaction](#interaction)
+ [x] [Extras](#extras)
    + [x] [Video work](#video-work)
    + [x] [Reflection probes](#reflection-probes)
    + [x] [Post processing](#post-processing)

## Basics

### Create project

+ Activate unity. Login and setting are required at first start. 
+ After that, create a new project. Specify the project name and save destination. 
+ Project has items to select 3D, 2D, but it is 3D as it is by default. Choose 3D
+ An asset is a package of unity scripts and materials gathered. From "Asset packages", add:
    + "Cameras"
    + "Characters", 
    + "Environment", 
    + "Prototyping"

---
### Interface

![interface](./TutorialResources/interface.png)

+ **The tool bar** includes tool switching buttons for executing and stopping the game, moving and deforming elements in the scene, and the like. 
+ **Scene view** is a screen where you can actually edit within the 3D environment of the game. Main Camera and Direction Light are installed by default. 
+ **The hierarchy tab** is list of elements arranged in the game scene 
+ **The inspector tab** is for detailed setting of the element when selecting an element in the scene. 
+ **The project tab** is a window that allows you to list materials, scripts, etc. in the project.
+ **Background tabs**
    + **Console** - error and debug messaging.
    + **Game** - When you press play, this kicks into gear.
    + **Asset store** - Add resources packages and goodies.

+ **Layout** - The interface is shapeable to your preference.

![anatomy](./TutorialResources/anatomy.png)

----

### Building scenes

+ Use **GameObjects**
    + Containers that hold different Components (3D model, textures, behaviours)
    + Every object in Scene is a GameObject (GO)
+ Use **Inspector**
    + View and edit objects and project settings
    + GOs contain Components e.g. 
        Transform,
        Camera,
        Colliders,
        Rigidbody,
        Custom Scripts.
+ Use **Scene View**
    + Free position objects, Camera, lights and interactable triggers
    + Clicking objects in the scene will highlight the GO in the Hierarchy and the Inspector will show you Components and subsequent variables.
+ **Scripting**
    + Add interaction behaviours, user input processing, where the action happens


----

### Gameobjects and Transforms - Placement, movement, rotation, deformation operation of objects

Basic primitives such as cube, sphere, capsule, cone, cylinder, board, etc. can be selected from menu. 

+ Select GameObject> 3D Object> Cube from the menu bar. 

![selectcube](./TutorialResources/selectCube.png)

+ A cube appears on the screen.

![cubeview](./TutorialResources/cubeView.png)

+ The mark on the leftmost hand of the toolbar is the movement of the viewpoint during work. Rotate the viewpoint with drag while holding down the option, drag to zoom while pressing control. 
+ With the target object selected, you can manipulate the object by pressing the Position, Rotate, and Scale buttons on the left side of the toolbar.

![control](./TutorialResources/cubeControl.webm)

+ You can also select actions with shortcut keys `q, w, e, r, t` respectively. 
+ Pan around a point with `alt`
+ You can also enter numbers directly in the inspector. 
+ This is common to all objects that can be placed in the unity scene.

#### Local vs World Space

+ Nest some Cubes in a GameObject.
+ Move around the holder GameObject

#### Details

Its important to see the difference between Local space and World space. In every scene,or any 3D world, there is a point of origin, often referred to as zero, as it is represented by the position (0,0,0).

"All world positions of objects in 3D are relative to world zero. However, to make 
things simpler, we also use Local space (also known as Object space) to define object positions in relation to one another. Local space assumes that every object has 
its own zero point, which is the point from which its axis handles emerge. This is 
usually the center of the object, and by creating relationships between objects, we 
can compare their positions in relation to one another. Such relationships, known 
as parent-child relationships, mean that we can calculate distances from other objects using Local space, with the parent object's position becoming the new zero 
point for any of its child objects." - [Source](https://www.scribd.com/read/253047721/Unity-Game-Development-Essentials)

----

### Material settings

+ From the menu bar, select Assets> Create> Material. New material is created in the project.
+ You can set details in the inspector window with material selected.

![mat](./TutorialResources/material.webm)

The first **Shader** is the format of shadow processing and can get pretty freaky. Although varied depending on the application, the default is basically **Standard**, with the physically based lighting simulaiton, it versatile and, most of the time will do the job.

In **Albedo** you can set basic colour and apply overall textures to the surface. The main visual appearance is determined here. **Metallic** is the degree of metallic luster, **Smoothness** is the degree of flatness of the surface.

+ Set the colour of the material
+ Drag the material onto the cube (in screne, hierarchy or on renderer)
+ Select an albedo texture from the Standard Assets

#### Details

Materials are a common concept to all 3D applications, as they provide the means 
to set the visual appearance of a 3D model. In Unity, the use of materials is easy. Any materials created in your 3D modelling 
package will be imported and recreated automatically by the engine and created as 
assets to use later. You can also create your own materials from scratch, assigning 
images as texture files, and selecting a shader from a large library that comes built- 
in. You may also write your own shader scripts, or implement those written by 
members of the Unity community, giving you more freedom for expansion beyond 
the included set. 

Crucially, when creating textures for a game in a graphics package such as Photo- 
shop, you must be aware of the resolution. Game textures are expected to be 
square, and sized to a power of 2. E.g.

+ 128 x 128 
+ 256 x 256 
+ 512 x 512 
+ 1024 x 1024 

Creating textures of these sizes will mean that they can be tiled successfully by the 
game engine. You should also be aware that the larger the texture file you use, the 
more processing power you'll be demanding from the player's computer. Therefore, 
always remember to try resizing your graphics to the smallest power of 2 dimensions possible, without sacrificing too much in the way of quality. 

----

### Prefabs

A **Prefab** stores object properties in a reusable way.
It is a template to make instances of in scenes.
Changes to prefabs propagate to all instances. Some important exceptions to this.

+ Drag your bouncy cube into the assets folder, this creates a prefab of that type.

----

### Camera and light settings

![cam](./TutorialResources/light-camera.webm)

You can also change the position and angle of lights and cameras with operations similar to other objects. 
By default, the light is linked with the background sky ( **skybox** ), and when it is tilted it will become evening or night. 
Also, the default is **Directional** , so it is like sunlight that uniformly hits the whole scene, so you can position it anywhere, but angle is important. 
Since you can arrange multiple lights , I think putting a spotlight ( **Spot** ) is necessary . 
The camera is a viewpoint when the game is actually executed, and a preview appears at the lower right while moving.
The angle of **view** of the camera can be changed along with **Field of View** on the inspector screen of the camera.

----

### Game Preview

![play](./TutorialResources/gameplay.webm)

By pressing the playback button on the toolbar, the scene view switches to game view, and you can preview the how the game will run.

----

### Save the scene

![play](./TutorialResources/save.webm)

Save the edited scene. When saved, a scene file is created in the project, and scene information is saved here. It just an xml file but ignore that for now.

----

### Export and Run application

+ From the menu bar, click File > Build Settings. The application export setting screen appears. 
+ Add the current scene to the build. Do appropriate settings (windows, osx).
+ Click Build And Run, the application file itself is stored in the folder of the project or elsewhere.
+ When launching the application, various setting screens appear; 
Screen resolution, Graphics Quality, Windowed.

----

## Physics Simulation

### Set gravity and use physical calculation

Physical operation is a calculation that simulates a space with physical laws like real space. 
Inside the computer, create another world that is similar in reality and that happens in real time. 

First give gravity. Gravity acts by adding a component called rigidbody to
the primitives such as the cube created earlier . However, since there is no ground, it falls as it is.

![rigid](./TutorialResources/rigid.webm)

### To make the ground

The **Prototyping** asset is a prefabricated block for verifying a rough game scene, and there are models such as walls and stairs besides the floor, which is convenient. Since assets of Prototyping added at the time of project creation are included in the project file,

+ Selected **FloorPrototype** and place it in the scene. 
+ Make the coordinates (Position) x: 0 y: 0 z: 0.

![floor](./TutorialResources/floor.webm)

+ Select your cube game objects in the scene or hierarchy
+  Add **Rigidbody** components to each.
+ Press play. They should fall.

Also, if you change the *material* of **Box Collider** , you change how the box interacts with other surfaces. 

+ Select a cube, select the bouncy material.
+ Press play. They should bounce.

![bounce](./TutorialResources/bounce.webm)

#### Details

In game engines, there is no assumption that an object should be affected by 
physics — firstly because it requires a lot of processing power, and secondly because it simply doesn't make sense. For example, in a 3D driving game, it makes 
sense for the cars to be under the influence of the physics engine, but not the track 
or surrounding objects, such as trees, walls, and so on — they simply don't need to 
be. For this reason, when making games, a Rigid Body component is given to any 
object you want under the control of the physics engine. 

Physics engines for games use the Rigid Body dynamics system of creating realistic 
motion. This simply means that instead of objects being static in the 3D world, they 
can have the following properties: 
 
+ Mass 
+ Gravity 
+ Velocity 
+ Friction

While more crucial in game engines than in 3D animation, collision detection is the 
way we analyze our 3D world for inter-object collisions. By giving an object a **Collider** component, we are effectively placing an invisible net around it. This net mimics its shape and is in charge of reporting any collisions with other colliders, mak- 
ing the game engine respond accordingly. For example, in a ten-pin bowling game, 
a simple spherical collider will surround the ball, while the pins themselves will 
have either a simple capsule collider, or for a more realistic collision, employ a 
Mesh collider. On impact, the colliders of any affected objects will report to the 
physics engine, which will dictate their reaction, based on the direction of impact, 
speed, and other factors. 

---- 

## Navigating space

### Walk around space: 1st person

Previously, we were watching the world through an inhuman fixed camera, which was placed by default, but I would like 
to arrange a character that we can freely move with.

It's hard to make from scratch, so this time I will bring it from a mature asset. 

First, uncheck the default Main Camera check box and make it inactive. 

+ Search for the prefab called **FPSController** in the
Characters Standard Assets, 
+ drag it and place it on the scene. 
+ When you play the game, you can operate with `W, A, S, D` + mouse; like a so-called FirstPersonShooter game. 

This turns control into a subjective and immersive world in which the world beyond what you are viewing through, the display (window), is navigable. 

![walk](./TutorialResources/walk.webm)

----

### Run around space: 3rd person

**Third Person Character** is also an arranged Prefab in Characters Standard Assets. 

+ Search for the **ThirdPersonController**
+ Add to scene 
+ Play the game, you can move with W, A, S, D. 

However, the camera does not follow.

+ Search for and add the **FreeLookCameraRig** prefab, add it to scene. Position the camera behind the character.
+ Drag the ThirdPersonController GameObject onto the `FreeLookCam` component `Target`. Now the main camera moves with you and allows twisting views.

Since the moving direction of ThirdPersonController is decided on the basis of the position of the 
camera, if the Rotation: Y of the camera is slightly shifted to the left or right, the backward movement of the character does not operate properly. 

![run](./TutorialResources/run.webm)

----

## Sound

### Place sound in space

+ First of all, get some sound files. Go to [Freesound](http://www.freesound.org), sign up and download some sounds. 
+ Create a folder called sound and drag and drop files there. The format of the sound file that can be read is mp3, wav, aiff, ogg, etc.
+ Place the RigidBodyFPSController in the scene from the Characters assets. 
+ Also add an Audio listener component that will be your "ears" to actually pick up the sound of the space. 
+ Just like a camera, make sure that only one audio listener exists in the scene.
+ Place an object such as cube on the scene and drag and drop the sound file there. Then, the sound file is added as an **Audio Source**. 
+ Loop playback when Loop is checked. 

When Spatial Blend is set to 1, it becomes a spatial way of hearing according to the position of the sound source. For example, the overall environmental sound should be placed with Spatial Blend set to 0 and 
individual sound effects placed in Spatial Blend 1.

### Make different sonic spaces

+ Create a new empty GameObject
+ Add the Reverb Zone component, pick a preset.
+ Do a couple more and make some overlapping boudnaries and dead zones.

When you move through these zones, any sounds that occur in them are processed with the reverb creating different sensations of space.

## Terrain

### Place Terrain object

+ Place a Terrain object to make terrain. The default size of Terrain is quite large, 500 * 500. 
+ Delete or hide any Floorprototype.

### Add a texture

+ In the inspector of the Terrain object, select Paint Texture of the brush's icon . 
+ Textures> Edit Textures> Add Texture> Select texture with Albedo Smoothness. 
+ Then the whole Terrain object becomes the selected texture.
+ You can select multiple textures, you can change the texture depending on the place like drawing a picture with the Paint tool.

### Make unevenness

+ Choose the mountain icon Raise / Lower Terrain . 
+ The place you clicked gets excited and becomes a mountain. Hold down the shift key and dent with a click.

### Plant a tree

+ Select Place Tree of tree icon . Edit Trees> Add Trees> Specify prefab of trees in Tree prefab. 
+ After that, you can specify density in Mass Place Trees and place it in the whole Terrain object. 
+ As with textures and terrain, you can add trees partly as you paint with paint tools.

### Plant the grass

+ Select the clover icon Paint Details . 
+ In Edit details> Add Grass Texture, select texture for grass flowers "GrassFrond 01 Albedo Alpha" etc in Environment Asset . 
+ After adjusting by adding color and size etc., you can plant grass as you draw with paint tool like other elements.

### Become scenery

+ Adjust variously, it will be like a landscape.

## Scripts

Scripts allow custom behaviours to GameObjects. You can just download and use them or make your own. In Unity you can write scripts using the C# language, you can write in others but I won't cover them.

### Make a rotator script

+ Assets> Create> C # Script
+ Give it a name such as `RotateTranslate`, no spaces!
+ Double-clicking on the script file opens the editor application, so we will edit it there.

```csharp
public class RotateTranslate : MonoBehaviour {

  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {

    transform.Rotate(1, 1, 0); 
    transform.Translate(0.01f, 0, 0); 

  }

}
```
**What is all this?**

We hava a `class` named `RotateTranslate`, 
it `inherits` from `MonoBehaviour`. The name of the script file and this class name have to match! `Start ()` and `Update ()` are the same as `setup ()` and `draw ()` of processing and openFrameworks. `Start ()` is executed only once at the beginning of the game, it initializes various settings etc. `Update ()` is executed every frame repeatedly at game execution, so you can move things, make it interactive, and so on. 

In the above code, the position of the target object and its rotation are changed every frame.

**Lets continue:**

+ Save the code file, and go back to the editor and confirm that there is no error.
+ Apply the script to a GameObject by either draging onto a GameObject in hierarchy or adding it in the inspector. 
+ Press the play 
+ The object should float and wind fluently. Good vibes.

### Less trival example

Instead of placing primitives and placing scripts there, let create a script that creates primitives places them for us. The following example will make 5 writhing cubes.

+ Create an empty object and name it "CubeHolder".
+ Create a new script and add the following

```csharp
public class RotateCubes : MonoBehaviour {
	
    private GameObject holder; 
    private GameObject[] objArr = new GameObject[5];
    private Vector3 defPos = new Vector3 (0,0,0);

    // Use this for initialization
    void Start () {
        print("test");
        holder = GameObject.Find("CubeHolder");
        defPos = holder.transform.localPosition;
        for (int i = 0; i < objArr.Length; i++) {
            objArr[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objArr[i].transform.localScale = new Vector3 (5,5,5);
            objArr[i].transform.localPosition = holder.transform.localPosition;
            objArr[i].transform.Rotate(i, i, 0);
        }
    }

    // Current rotation
    float c_rot = 0;

    void Update () {
        c_rot += 0.05f;
        for (int i = 0; i < objArr.Length; i++) {
            objArr[i].transform.localPosition = new Vector3 (defPos.x+Mathf.Sin(c_rot)*2, defPos.y+Mathf.Cos(c_rot)*2, defPos.z);
            objArr[i].transform.Rotate((i+1)*0.1f, (i+1)*0.2f, (i+1)*0.3f);
        }

    }
}
```

![scripting](./TutorialResources/ScriptExample.png)

### Public variables and private variables

If you set the variable as `public` you will be able to change it from the inspector. Set variables that you do not want to change externally as `private`.

```csharp
public class PublicPrivateExample : MonoBehaviour {

	public float g_x; 
	public float g_y;
	private float g_z; 

	// Use this for initialization
	void Start () {
		g_x = 0.0f;
		g_y = 1.0f;
		g_z = 0.0f;
	}

	// Update is called once per frame
	void Update () {				
		transform.position = new Vector3 (g_x,g_y,g_z);
	}
}
```

#### Using the inspector with scripts

If you need to have objects communicate or do stuff together you can use the public variable to reference objects. This *might* be cleaner than using `GameObject.Find ("object name")` all over the place.

+ Create two Cubes in the hierarchy, name them "Cube_A" and "Cube_B".
+ Add new C# script "ObjectController", add this:
```csharp
public class ObjectController : MonoBehaviour {

	GameObject cubeA; // The found object
	public GameObject cubeB; // Editor configured object

	void Start () {
		cubeA = GameObject.Find ("Cube_A");
	}

	void Update () {
		cubeA.transform.Rotate(0, 1, 0);
		cubeB.transform.Rotate(0, -1, 0);
	}
}
```

## Interaction

A simple way to get stuff to work from human or system action is using `UnityEvents`. The allow message to be sent around your scene and game without lots of direct connections. Complex at first, but a good way to do some things. We won't cover how to use these in code yet, just connecting them in the inspector.

+ In hierarchy, add new object `UI` > `Event System`
+ Go to the camera on our first person controller, `Add Component` > `PhysicsRaycaster`
+ Create something we can click on in the scene, cubes?
+ On each one `Add Component` > `EventTrigger`
+ Press `Add New Event Type`> `OnPointerClick` (This means mouse click)
+ Add new entry to this list
+ In the Object selector, drag the cube into it
+ In the function pull down menu, select `GameObject` > `SetActive (bool)`

This pretty boring example shows you how to deactivate a clicked object. So lets add a more likely example:

+ Import the Kino packages (Datamosh, Isoline)
+ Go to Main Camera on player controller Add Component > IsoScroller
+ Add new C# script "ViewSwitch"
```csharp
using UnityEngine;
using Kino;

public class ViewSwitch : MonoBehaviour {

    public Isoline isoline;
    bool state = false;

    public void SwitchCameraEffect(){
        state = !state;
        isoline.enabled = state;
    }

}
```
+ Add the "ViewSwitch" component somewhere in the screen, add the camera to the isoline public property.
+ Now when you click the cube it is a gate way between the island and a contour data landscape effect thing!

This is still just turing stuff on and off though...

## Extras
### Video work
#### Movie

+ Create 3D GameObject called `Plane`, rename this to something sensible
+ Rotate it to face towards you.
+ Drag a video file onto it.
+ Press play!

#### Webcam

+ Create a `Plane` like before, give it the following (widescreen) transform in the inspector:
    + rotation: (x: 90, y: 90, z: -90)
    + scale: (x: 1.92, y: 1, z: 1.08)
+ Create new C# script named "WebCam"
```csharp
public class WebCam : MonoBehaviour {

    public int Width = 1920;
    public int Height = 1080;
    public int FPS = 30;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        // display all cameras
        for (var i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
        }

        WebCamTexture webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}
```

![scripting](./TutorialResources/WebCam.png)

### Reflection probes

Let's hack some modernist art:

+ Create a `Reflection Probe`
+ Set resolution to 1024
+ Create new material "Metalic"
+ Set `Metalic` to 1
+ Set `Smoothness` to 1
+ Add four cubes, apply Metalic material to each of them
+ Space them like [Robert Morris "Untitled"](http://www.tate.org.uk/art/artworks/morris-untitled-t01532)

### Post processing

+ Import the Post Processing stack from Asset Store
+ Add Component `Post-Processing Behaviour` to your camera
+ Create new `Post-Processing Profile`
+ Add the profile to the behaviour on tha camera
+ Edit the profile like photoshop

Warning, this can really effect framerate on mobile and vr! Use carefully, and always check its effect on rendering cost.