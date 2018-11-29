# Digital-Directions-Workshop-Nov18
Workshop on Unity covering basic API awareness, some scripting, and use of creative coding tools Klak.

Download link https://github.com/VizRCA/Digital-Directions-Workshop-Nov18

## Overview

+ Intro to unity, swift run through, tell me what you know and don't know! 45m
+ Scripting basics 45m
+ Designing interactions with Klak 45m
+ Narrative control: Dialog systems, Timelines and animation controllers || Setting up android for oculus go || Anything else 45m 

# Intro to Unity

[Relative reference to repository file](./Instructions.md)


# Scripting Basics

## Coding mindset

Breaking down "problems" into things you can describe and then apply logic to.

Looking for places where you can aggregate behaviours to allow manageable complexity.

**DO** Terminal>python>>> 
```python 
import this
```

**Key points**

+ Code must flow in order.
+ The software is flowing in a series of events.
+ Things can be set-up once or done all the time or reactively.
+ Programs use input and adjust behaviour based on instructions.

## The Basics of Programming with C#

We ignore *Unity* for a minute to set our minds on what all the words and terminology is, this can help you [Google](https://lmgtfy.com/) stuff later when you need help.



### Variables

Stolen from [here](https://www.codingforart.com/processing-section-3/).

Variables give us the power to vary our programs creatively.
Variables store information (data) that your computer uses in flexible ways.
#### Types of basic variables
The type of variable must be specified in the program so the computer can actually use it.

*Integer Variables*

These are variables that hold whole numbers (no fractions, no decimals).
+ Example Values: -2,-1,0,1,2,3
+ The code for declaring an integer variable: ```int```

*Float and Double Variables*

These are variables that hold decimal numbers (fractions, not whole numbers). The name “float” comes from thinking of these decimal numbers as having “floating point values". "Double" comes from being a double precision version of a "float".
+ Example Float Values: 4.3f, 7.9999f, 0.876764f, -10.98f; note the use of "f" at the end of the number.
+ The code for declaring a float variable: ```float```
+ Example Double Values: 4.3, 7.9999, 0.876764, -10.98; Look no f!
+ The code for declaring a double variable: ```double```

*Character Variables*

These are variables that hold letters, letters are enclosed by single quotes. You may use variable integers to create an interactive program that responds when certain keys are pressed. 

+ Example Values: ‘c’,’t’,’a’

+ The code for declaring a character variable: `char`

*String Variables*

These are variables that an array of letters, enclosed by double quotes.

+ Example Values: "finger","address","elocution"

+ The code for declaring a string variable: `string`

*Boolean Variables*

These are variables that hold the value of either true or false.

+ Examples (only two options): true, false

+ The code for declaring a boolean variable: `boolean`

**Key points**

Variables must declare:

1. **type**

2. **name**

3. **value**

...so computer to use them.

```csharp
// Type Name = Value;
int myPinNumber = 1234;
float timeToMakeDecision = 495.5f;
bool tomIsALiar = true;
bool isFalse, isNotTrue; // Un valued default to false;
int thisIsZero;
float thisIsAlsoZero;
string coreLifeSkill = "flattery";
```
#### What to do with variables?

As a simple case variables can be used like algebra variables

```csharp
int dob = 1984;
int year = 2018;
int age = year - dob;
```

### Maths Operators

Maths ones include

+ addition `+`, subtraction `-`
+ multiplication `*`, division `/`
+ remainder `%`

[Full list here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/operators), cover more as topics arise.

### Classes

**Classes & objects** - a class is a collection of variables and methods that can be reused eg

```csharp
// Simple car class
public class Car
{ // <- Blocks of code are enclosed by curly brackets: { } 
    String name;
    float maxSpeed;

    // Class constructor, stuff it does when it gets made
    public Car() 
    {
         name = "Tina";
         maxSpeed = 30.0f;
    }
}

```

Objects are instances of classes create when you run the program.

### Method Signatures

*class, Public/private, methods and returns*

In programming, the instructions we specify start with how different variables and methods are available to other parts of the application/game/code.

Methods are declared in a `class` or `struct` by specifying the access level such as `public` or `private`, optional modifiers such as `abstract` or `sealed`, the return value, the name of the method, and any method parameters. These parts together are the signature of the method.

A **Method** is a code block that contains a series of statements. In C#, every executed instruction is performed in the context of a method.

**Method Parameters**  are enclosed in parentheses and are separated by commas. Empty parentheses indicate that the method requires no parameters.

**Access Level** indicates how other classes and commands can interact with a class. For instance, ```public``` means another object in the app can access it. Other types include `private`, `protected`. More on this in the context of Unity later.

```csharp
public class Car
{ // <- Blocks of code are enclosed by curly brackets: { } 
    String name; // <- Private by default
    float maxSpeed;
    public float currentSpeed = 0f; // Other things can change this

    public Car()
    {
         name = "Tina";
         maxSpeed = 30.0f;
    }
}

```
```csharp
abstract class Motorcycle
{
    // Anyone can call this.
    public void StartEngine() {/* Method statements here */ }

    // Only derived classes can call this.
    protected void AddPetrol(int gallons) { /* Method statements here */ }

    // Derived classes can override the base class implementation.
    public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

    // Derived classes must implement this.
    public abstract double GetTopSpeed(); 
}
```
```csharp
class TestMotorcycle : Motorcycle
{

    public override double GetTopSpeed()
    {
        return 108.4;
    }

    static void Main()
    {
        
        TestMotorcycle moto = new TestMotorcycle();

        moto.StartEngine();
        moto.AddPetrol(15);
        moto.Drive(5, 20);
        double speed = moto.GetTopSpeed();
        Console.WriteLine("My top speed is {0}", speed);            
    }
}
```

### Logic

#### Conditionals

Kitties have whiskers –> true
17 is smaller than 16 –> false
10 equals 10 –> true

#### Boolean Operators

+ `>` greater than
+ `<` less than
+ `==` equal to
+ `!=` not equal to
+ `>=` greater than or equal to
+ `<=` less than or equal to

Language assumes left to right.

**Important Key Note!**

If you see:

```if (x == y) { // you are asking is x equivalent to y:```

But, if you see:

```x = y ; // you are stating that set x is equal to set y```

#### Logical operators

Yes, moar symbols!

+ `&&`  AND
+ `||`  OR
+ `!` NOT

#### Conditional Statements

`if` statements allow flow control.

What value is the `bool`?

```csharp
int x = 9;
bool answer = ((x < 10) && ( x > 5)) || ((x > 20) && (x < 25));
```
   
```csharp
int x = 9;
bool answer;
bool partA;
bool partB;
if(x < 10){
    if( x > 5){
        partA = true;
    }
}

if(x > 20){
    if( x < 25){
        partB = true;
    }
}

if(partA || partB) answer = true;

// See why the top one is better? But while you learn, do it the long way.
```

Combined **if, else, elseif** statements allow more flow control based on what is being evaluated.

```csharp
int t = 0;
int maxTime = 30;
string status = "start";

while( t < maxTime ){
    if( x < 5 )
    {
        status = "counting, less than 5";
        t++;
    }
    else if (x >= 5 && x < 25 )
    {
        status = "counting, between 5 and 25";
        t++;
    }
    else
    {
        status = "counting, between 25 and 30";
        t++;
    }
}
status = "counting complete";
```

#### Loops

Though I snuck one in before, loops such as `while` and `for` allow sets of statements to be evaluated multiple times, until a certain condition is met. 

```csharp
for (initializer; condition; iterator)
    body
```

```csharp
int count = 0;
for (int i = 0; i < 5; i++)
{
    count = i;
}
```

### Arrays

The previous example is kind of pointless, a main reason to use for loops is to iterate Arrays. Arrays are lists of variables stored in one instance.

```csharp
int[] numbers = new int[]{3,4,5};
int modifier = 2;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= modifier;
}

// numbers now equal 6, 8, 10
```


### Algorithms - Too much for now
### Abstraction & Inheritance - Too much for now

## Unity scripting

### How is Unity different from other Creative Coding platforms?

For those familiar with *Processing* or other Creative Coding platforms, *Unity* presents a different problem. Firstly its a different language, a sub-set of C#. In *Processing* you have two places where the action happens ```setup()``` & ```draw()```, in *Unity* the action happens everywhere! Each ```GameObject``` has its own version ```setup()``` & ```draw()``` within the ```MonoBehaviour``` class. This setup is a modified form of the Entity-Component-System (ECS) architecture. Its not true ECS because data and behaviour are linked together on the same class.

Key points:

+ **Everything is on a GameObject**
+ **Scripts allow access to behaviours and processes on GameObject's in scripts**

### Scripts

Scripts allow custom behaviours to GameObjects. You can just download and use them or make your own. In Unity you can write scripts using the C# language, you can write in others but I won't cover them.

### ```MonoBehaviour``` breakdown, order of operations

Unity executes the same order on all ```GameObjects```, but some stuff happens once, and others on every frame, and others when specific things happen.

[Unity runtime execution order](https://docs.unity3d.com/Manual/ExecutionOrder.html)


![Runtime order](https://docs.unity3d.com/uploads/Main/monobehaviour_flowchart.svg "Script Lifecycle Flowchart")

### Special Unity Classes Variables

`Transform` - holds position rotation and scale, plus extra tools to orient objects.

`Vector3` - holds cartesian coordinates X,Y,Z. These are float values. Positions and euler rotations are most common use of this class.

`Quaternion` - freaky space physics way of doing rotations. 4D object X,Y,Z,W

### Debugging

You can send yourself messages to the console using a command, this allows you to check what and when something is happening.

```csharp
public class Debugger : MonoBehaviour {
    int counter;
    // Use this for initialization
    void Start () {
        Debug.Log("This script has started");
    }

    // Update is called once per frame
    void Update () {

        if ( Random.value > 0.8f ) // <- 20% probability
        {
            counter++;
            Debug.Log( "Counter value: " + counter);
        }
    }

}
```

### Make a rotator script
+ Create a cube in the scene
+ Assets> Create> C # Script
+ Give it a name such as `RotateTranslate`, no spaces!
+ Double-clicking on the script file opens the editor application, so we will edit it there.
+ Save script, add it to cube.
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
    // Current rotation
    float c_rot = 0;

    // Use this for initialization
    void Start () {
        holder = GameObject.Find("CubeHolder");
        defPos = holder.transform.localPosition;
        for (int i = 0; i < objArr.Length; i++) {
            objArr[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objArr[i].transform.localScale = new Vector3 (5,5,5);
            objArr[i].transform.localPosition = holder.transform.localPosition;
            objArr[i].transform.Rotate(i, i, 0);
        }
    }

    

    void Update () {
        c_rot += 0.05f;
        for (int i = 0; i < objArr.Length; i++) {
            objArr[i].transform.localPosition = new Vector3 (defPos.x+Mathf.Sin(c_rot)*2, defPos.y+Mathf.Cos(c_rot)*2, defPos.z);
            objArr[i].transform.Rotate((i+1)*0.1f, (i+1)*0.2f, (i+1)*0.3f);
        }

    }
}
```



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

### Using the inspector with scripts

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
		// Rotate right (around the Y axis)
        cubeA.transform.Rotate(0, 1, 0);
        // Rotate left (around the Y axis)
        var angle = cubeB.transform.rotation.eulerAngles.y - 1;
        cubeB.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
	}
}
```
### Parent child relationships

You can access objects in the hierarchy through code. Every GameObject in a scene can be found using a common set of methods.

```csharp
public class AnimationController : MonoBehaviour
{
    Animator animator; // <- Declare the variable for private use.

    void Start()
    {
        animator = GetComponent<Animator>(); // <- there must be a AnimationController for this to work!
    }

    void OnEnable(){
        animator.SetTrigger("Move"); // <- Must be animation state in the controller called Move
    }
}
```

### Events