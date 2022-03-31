# Repository Architecture Style

We chose the Reposoitry Architecture style because our game revolves around a central data store whose data is accessed and modified repeatedly.  

Our main driver for chosing this architecture style was that we needed a central data store where the objects (John Smith, enemies, etc.) could access/modify the data repeatedly. 

This was a nessesity as Unity documentation says that the Update() function (which any object with a script has) is called once per frame, so the data store is accessed/modified quite a bit. 

Diagram: [Repository Architecture Style](repository.png)
