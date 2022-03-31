# Repository Architecture Style

We chose the Repository Architecture style because our game revolves around a central data store whose data is accessed and modified repeatedly by game objects. (eg: John Smith, enemies, etc..)  

This was a necessity as Unity documentation says that the Update() function (which any object with a script has) is called once per frame, so the data store is accessed/modified quite a bit. 

Diagram: [Repository Architecture Style](repository.png)
