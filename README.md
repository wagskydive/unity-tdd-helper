# unity-tdd-helper
unity package to help generating classes and functions and automates the creation of testing classes and functions



Unity Editor Tool



* PLAN: 
  1 architacture file
  ```javascript
{
  "Project Name": "project-name",
  "Description": "This is my amazing project"
};



```
  2 Architecture class has all the data loaded of the system diagram





* UML diagram window
  > visualizes the system from my-system.architecture/ Architecture class?

* project creation window
  - shows only on menu item "create new project"
  - Has a form to input data
      - Project Name
      - What - Description
      - Where - project location (maybe automated from expected filestructure below
      - How - Description where user is asked to define the the way the system is intended to work
      - ? Flag create example files

  - Creates project-name.architecture (is json file with .architecture extension)
  - Creates Folder Structure
  - ? Creates Example Files


* function creation
  - What: Function name and function expected result
  - Where/When: Function paramenters and resource locations
  - How: function logic
* Interface creation
  - Creates interfaces that contain functions


* Test Creator

- creates tests from function definitions
- leaves logic open but asserts its behaviour


* creates and reads  my-system.json file with the structure of the system
  - !Expects a certain folder structure

* reads package-configuration.yml
  
* has a function to generate new .cs files


* has a function to read into .cs file structure
 
* Expects a certain folder structure
    - ../MY_UNITY_PROJECT_FOLDER/Assets/the-repository-of-my-project
     - /Editor
     - /Runtime
     - /UnitTests
     - .gitignore
     - package.json
      
  > Read .csproj
  > Validate json and show if it has the same functionality as the json
  


