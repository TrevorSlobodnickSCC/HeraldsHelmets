## Description

This is a website that acts mainly as a product catalogue for Helmets sold by Heralds Helmets (a fictional company).

## Time to Complete

Roughly 8 hours

## Task Log

***[Sunday, Oct 10, 2021]***

*1:00pm*

- Created the project
- Changed the Privacy page to About and added the code necessary to make this change work
- Successfully built/ran the project with no errors
- Initial commit and pushed to Github

*1:45pm*

- Gave the About page its own controller and view, rather than be apart of Home
- Created new view/controller for Products
- Although I did the same thing for the About page, the Products page is displaying "404 cant be found"

*2:15pm*

- After a couple of rebuilds, it is now showing the Products page

*3:00pm*

- Created Helmet.cs in Models folder
- Added the NuGet packages for scaffolding
- Similar error to before, it scaffolded a previous version of the Helmets.cs file, not the current one, causing a lot of "not found" errors

*3:30pm*

- Deleting the files created from scaffolding and rerunning the scaffolding command fixed the issue
- Deleted the Products View and Controller, replaced its space in the nav with Helmets
- Ran into some issue using the dotnet ef command, it was complaining about having multiple
DbContext files and not knowing which one to choose. I had to rerun those commands adding
"--context MvcHelemtContext" to the end of the command in order for it to complete successfully

*4:45pm*

- Finished adding the example entries to SeedData
- Ran the program with no errors, it is now seeded

*5:00pm*

- Finished adding content to the About page (About.cshtml)

*7:00pm*

- I realized I forgot to implement the half rating scale so I will need to add that in,
delete all the scaffolding code and then rerun the scaffold command

*8:00pm*

- Deleted everything and readded it with the scaffold commands, everything is running

*8:30pm*

- Just noticed the currency is appearing as ¤ instead of $, after googling, ¤ means unknown currency,
I am not sure how to fix this because I checked the tutorial and they did the same thing...


***[Wednesday, Oct 13, 2021]***

*4:00pm*

- Luckily, someone on stackoverflow also had this issue https://stackoverflow.com/a/46165148, the post
suggests there may be an incorrect server configuration, so the solution is to do it programatically in
the Startup.cs

- Added the code to Startup.cs and that has fixed the currency issue

*4:30pm*

- When viewing the project, it does not display my css changes. I also checked the dev tools and it is
not picking up my css changes

- Holding shift and clicking the refresh button fixed the issue

*5:00pm*

- Applied some styles that change the color of the website

*11:30pm*

- Added some images to the home page

- Had some trouble figuring out how to link the image in the href tag but after playing around with it
I figured it out

- During testing what the images looked like in different device sizes I found out that the mobile
nav menu blends into the background, so I added some css to give it a white background

- 2 of the images on the home page are larger than the smallest one, I could shrink the images through
javascript/jquery, but to keep it simple I decided to just crop them manually


***[Thursday, Oct 14, 2021]***

*1:00am*

- Added the Baloo Bhaijaan font and added a style so all h1 elements use this font

- Fixed an issue with the button on the home page where it would overlap the images,
did this by putting it inside of a div

*5:00pm*

- Published the project to azure

- After looking through each page (on azure), I noticed that the Helmets page gives an error rather than
displaying the products, currently trying to figure out how to debug this

- I also noticed the dev tools mentioned that the font file couldnt be found, this was due to an incorrect
path, which has now been fixed

*5:00pm*

- I think the error I am getting is because tof the environment change, in my Startup.cs I say to use SqLite
for development and SqlServer for everything else, I am going to try using SqLite nomatter what environment and
see if that resolves the issue

- It did not resolve the issue itself, so I temporarily did what asp suggested and forced the "Developer"
environment, which gave me more info on the error. It said that the Helmets table could not be found and
I needed to apply the migrations. After apply the migration and republishing, the error disappeared and I
could see all the records

- I republished again to remove the code that force the "Development" environment, but didn't change
anything with the database (still using SqLite rather than SqlServer)