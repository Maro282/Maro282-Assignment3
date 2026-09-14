# ------------------------------ PART G  -------------------------

##  ----------  Q1  -----------
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>

## ------------------------------



##  ----------  Q2  -----------
 region and endregion don't affect the compiled code but we may still using it in some scenarios like :-
  1- i have joined a new project and i got task to update something in a file have a thousands lines of code that
     i will not use in this case we can use regin to make the file more readable


## ------------------------------


##  ----------  Q3  -----------
   we use /// instead of // if we need to make a documentaion for a specific element like a class of method
   if we use that method elsewhere in the project and hover on it we will see the documention or the summary we have created by ///

## ------------------------------


##  ----------  Q4  -----------
   there is no global scope in c# because any field or function must be included in a class or struct 
   and the closest equivelent for this concept is static field which could be used in any part of project by using ClassName.fieldName

## ------------------------------