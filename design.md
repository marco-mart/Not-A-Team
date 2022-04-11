# John Smith Design
![Architecture Design](repository.png)

- Objects access data from the centralized database, modify it accordingly, and then write the updated data back to the database.
- This happens every frame.

## Architecture: Repository Model

The architecture design for John Smith is a repository model. We went with this design because our game revolves around a central data store whose data is accessed and modified repeatedly by game objects. (eg: John Smith, enemies, etc..)

Any object with a script has an Update() function that is is called once per frame, so the centralized database is accessed/modified quite a bit.
