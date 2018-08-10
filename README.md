# AutoService
Solution using ASP.NET MVC Core 2.1 (PoC Testing)

No real project here, just something done on my free time.

# Welcome

Hi! 

Although the original was intended for version ASP.NET core 2.0, I've done it **on version 2.1** which changes some parts of the code, structure and logic.

I was able to have a working version on the new framework, however two parts I could not fix:

 - The _ManageNav partial view: Is not showing... I've tried but I could not make it appear.

I've decided to share it on GitHub for those that might find it useful.

If you happen to know the way to fix my _ManageNav issue, or have any suggestion/bugfix/recommendation, please do a PR, It will be greatly appreciated!.

# Using it:

Just download it and open it on Visual Studio, you need to create the DB Schema and also fill in your own configuration settings (for database and for sending Emails).

On Visual Studio, open the NuGet package manager and issue the command: 

> Update-Database 

That will take care of creating the DB Schema for you, then you only will need to register on the app, and then change the profile type to your account to be Administrator. That or temporarily modify the registration code so you can auto register as admin (and then revert back to the original code.

Have fun!
