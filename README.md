# fullstack-interview
A sample project to use for challenging some volunteers during job interviews.

## Challenge

You will create an *Angular* frontend application for an already existing backend solution with a basic set of features to manage *protocols*. 

By increasing features in the frontend you will also extend the backend's functionality alongside with frontend.

### Requirements
The requirements for the frontend are the following:

  - The user has a view to list all *protocols* at once, beside this he can
    * filter and sort on the *protocols* metadata
    * only display a subset of *protocols* to avoid huge data loading (pagination / infinite scrolling) 

  - The user has the possibility to trigger the following actions for each data set:
    * delete a *protocol*
    * open and display the related PDF document of a *protocol* and 

  - The user can select a specific *protocol* and view the details of this *protocol*.  

  - The user has the possibility to search for *protocols* (e.g. for its "name") using a search-mask

  Optional:
  - Integrate a login mask for a user called "demo" and restrict access for non logged in users for the requirements above.
  - Harden the http-request responses (e.g. return an `404` if  a user requests details for a non existing *protocol*) 

### Tools

- All tools provided by the `.Net` or `Angular` frameworks itself
- Any non restricted libraries provided by `NuGet` or `npm`
- Any non restricted UI component libraries like `Material` or `Bootstrap`

### Database

Use the following commands to create the `SQLite DB`

```bash
dotnet tool install --global dotnet-ef
dotnet ef database update # in "SimpleAPI" directory
``````
