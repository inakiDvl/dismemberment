# Dismemberment
A simple yet scalable dismemberment system for Unity.

It raplaces the object you want to dismember with a rigid bodied coppy fo it.

Here we can see how two parts are dismebered separedly:

![alt text](2025-07-10-18-26-46.gif)

Now at the same time:

![alt text](2025-07-10-18-27-01.gif)
## How to use
1. Attach Dismemberable to the original object you want to dismember.
    - Each object you want to dismember should have one.

        ![alt text](image.png)
2. Asing the body field.
    - This will be a  copy of the orinal object with a rigidbody and a collider attach to it.
    - To make a copy of an object with a Skinned Mesh Renderer, the copy must have a simple Mesh Renderer and a Mesh filter with the same mesh asigned.
        
        ![alt text](image-1.png)
    - The copy should have the same parent bone as the original, so it moves like the original.
3. If the Dismemberable has a child that's also a Dismemberable, asing it.
    - This way it will dismember all the Dismemberable in cascade.
4. Find a way to call Dismember() on Dismemberable.
    - In my case I just ray cast from the camera to the mouse position.
