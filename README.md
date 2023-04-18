# Instagram Parser
## The program I created in 2020.  Instagram followings of a list of Instagram pages using Selenium WebDriver.

This is a C# solution that parses Instagram followings of a list of Instagram pages using Selenium WebDriver. The method opens each page, clicks on the "following" button to display the list of users, scrolls down to load all users, and then extracts the username and profile link of each user, which is stored in a custom-defined FollowModel object. The FollowModel objects are then added to a static list FollowsList.Follows to keep track of all the users. Finally, the method sets a flag to indicate that the parsing is done. The method also writes log messages to a text box to report the progress and any errors encountered during the parsing.
