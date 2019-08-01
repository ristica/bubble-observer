# bubble-observer
use of observer pattern on bubbling events

well, let us assume you have a structure (just like a pyramid) - a root element and, let's say, 3 children and each of them has another 3 children, and so on...

imagine that for some reason an update has happened on 2nd level's child and the parent of the updated child needs to be notoficated about it...

if that is the case - then "bubble-observer" may help you :-)
