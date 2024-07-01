# ScreenLocker
A simple program to lock screen then requires entering codes to unlock, but each code has a timer and the screen will be locked again after the timer of entered code is up.

>My neece wanted to borrow my computer to play games, but when I told her the time is up, she said she'll quit after finishing the current game, yet she ended up play extra minutes. I remember that back then when I was a kid, in an internet cafe I had to buy "codes" to unlock the computer, and each code have its own timer (for example, 30 minutes code allows me to play exactly 30 minutes, then the screen will be locked). I couldn't find that program anymore so I wrote this.

Written in C#. The upload service is written in php.

Workflow:  
1. Open program and generate codes.
2. Save codes to local and upload to server.
3. Open web browser to see codes.
4. Confirm to lock screen. An input is shown to enter code.
5. When entering a code, the program will check codes in server or in local.
6. The screen will be unlocked if the entered code is valid.
7. When time is up, the screen will be locked again.

To do:
- UI.
- Boss key: A shortcut key to bring up the 'enter code' interface (to extend times or to enter Master code).
- Master code: A code to bring back the main UI (to exit program).
- Ignore if code was used.
- Create random codes with given inputs (for example: Create 10 of '15 minutes' codes and 5 of '30 minutes' codes).
- Prevent closing program (shortcut, and in Task Manager).
- Encrypt json file.
- Alarm the user when time is about to up (5 minutes left, 10 seconds left,...)
- ...
