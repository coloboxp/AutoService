# AutoService
The final project of a ASP.NET MVC Core 2.0 Course (ported to Core 2.1)

# Welcome

Hi! 

I've finished a MOOC about ASP.NET MVC Core 2.0 and this is the project's result.

Although the course was intended for version ASP.NET core 2.0, I've done it **on version 2.1** which changes significantly some parts of the code, structure and logic.

I was able to finish the course and have a working version on the new framework, however two parts I could not fix:

 - The _ManageNav partial view: Is not showing... I've tried but I could not make it appear.
 - The footer at the _Layout view: It won't go to the bottom... looking on the net, seems to be needed some kind of CSS wizzardy to make it work, and I can't yet figure out how to do it.

I've decided to share it on GitHub for those that are taking the same MOOC or others that happen to have a similar situation, so they can find a way or workaround with my code.

If you happen to know the way to fix any of my two issues, or have any suggestion/bugfix/recommendation, please do a PR, It will be greatly appreciated!.

# Using it:

Just download it and open it on Visual Studio, you need to create the DB Schema and also fill in your own configuration settings (for database and for sending Emails).

On Visual Studio, open the NuGet package manager and issue the command: 

> Update-Database 

That will take care of creating the DB Schema for you, then you only will need to register on the app, and then change the profile type to your account to be Administrator. That or temporarily modify the registration code so you can auto register as admin (and then revert back to the original code.

Have fun!
