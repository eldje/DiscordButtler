# DiscordButtler

Discordbuttler is an extensional Discord Bot written in C#. It utilizes a very powerful and leightweight way of adding Extensions to the Bot with absolutely no need to learn anything. 

### Requirements
* .Net Framework 4.5.2
* A brain

### Setting up the Buttler
At this stage the bot is very Alpha and you have to compile it on your own and add the needed configs on your own. 
- Restore the dependencies from the NuGet package.config file([Tutorial](http://stackoverflow.com/questions/6876732/how-do-i-get-nuget-to-install-update-all-the-packages-in-the-packages-config))
- Compile the bot and save this as "Credentials.json" under bin/Release/Data/ (You have to create the Data folder!)
```json
{
  "Email":"John.Doe@Sample.com",
  "Password":"Samplemail"
}
```
- Adjust it to the credentials of your bot account
- Done :)
### Created with
* [Discord.Net](https://github.com/RogueException/Discord.Net)
* [Newtonsonft.Json](http://www.newtonsoft.com/json)

### Big Love
goes to all the crazy people in the CSharp Discord. They help with every problem related to .Net and generally it is a nice community to be in. [Check it out!](https://discord.gg/0np62rq4o8GnQO9l)

Greetings Xeronik
