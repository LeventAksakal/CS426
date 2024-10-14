# Unity Homework 1

## Introduction
This homework is designed to help you get familiar with the basics of Unity. You will create a simple project that includes basic game objects, components, and scripting.

## Objectives
- Understand the Unity interface
- Create and manipulate game objects
- Apply components to game objects
- Write basic C# scripts to control game objects

## Instructions

### 1. Setting Up the Project
1. Open Unity Hub and create a new 3D project named `Homework1`.
2. Save the project in the directory `/D:/Programlar/Unity Projects/github/Homeworks/Homework1`.

### 2. Creating Game Objects
1. In the Hierarchy window, create a new 3D object (e.g., Cube).
2. Rename the object to `Player`.

### 3. Adding Components
1. Select the `Player` object.
2. In the Inspector window, add a `Rigidbody` component.

### 4. Writing Scripts
1. Create a new C# script named `PlayerController`.
2. Attach the script to the `Player` object.
3. Open the script and add the following code:

```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
```

### 5. Testing the Project
1. Press the Play button to run the project.
2. Use the arrow keys or WASD keys to move the `Player` object.

## Submission
- Ensure your project is saved and all changes are committed to your GitHub repository.
- Submit the link to your repository.

## Conclusion
By completing this homework, you should have a basic understanding of how to create and manipulate game objects in Unity, apply components, and write simple scripts to control game behavior.
