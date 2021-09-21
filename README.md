# corollary
.net fooling around


## web api

[tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio)


### example

Jowel
: The space or arch between bridge struts, or piers

Pier
: an intermediate support for the adjacent ends of two bridge spans
: a structure (such as a breakwater) extending into navigable water for use as a landing place or promenade or to protect or form a harbor


### endpoints

/api/entries

- get `/api/entries/`
- get `/api/entries/{entryID}`
- post `/api/entries/{headword}`
- put `/api/entries/{headword}`
- delete `/api/entries/{headword}`

ex:
> pier, jowel

/api/entries/{entryID}/definitions

- get `/api/entries/{entryID}/definitions`


### moving parts

- http requests
- controllers
- data access layer