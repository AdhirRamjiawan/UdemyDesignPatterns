

Thoughts:
1. Maybe the Prototype pattern is useful when the creation of an object is more inefficient than cloning the object?
2. Perhaps in a GFX application where the creation of the object needed some rendering. To rerender for each new instance when there's no difference could be a waste of CPU/GPU time.
3. Perhaps in a business application, where the creation of an object needed intensive DB operations. To query the DB for each new instance when there's no difference could be a waste of resources and time.