# Computer-Security
Computer Security Sol. was developed with the aim to secure ones computer at domestic level. Domestic level here means to use the method by which one can secure the data stored in his P.C including text file, images, network etc.

It contains various modules which independently provide tools that can help you secure your data. These modules will be explained in details below. But first let me describe you the technology that was used to develop the software.

Visual Studio was the software and Visual Basic.net/VB.net was the language used. The framework was 4.6.1 and the database was implemented with SQL-Server. The reason of using VB.net was because of its comfortable and easy to use environment. The "Rapid Action Development" helps to optimize the functionality of the code. Since the software requires U.I interface to interact, so the use of VB.net with its I.D.E was a good option

1.  Get Your Ping....

Ping is the software utility used to test the reachability of hosts on an I.P network. It measures the round trip time of messages sent from host to the destination computer and echo back to the source.
As per the U.I there is a black box which is the output box, where the end result will be displayed. Just below it is a text box which accepts the input and next to it is a button, which on pressed executes the function.<br/>
The text box takes the input as an IP address and when the button is clicked, it will display whether the connection between both the networks are available or not.
                      
2.  Network Messenger....

An IP address is the unique numeric label given to each device in a network that use Internet Protocol for communication.
"Net Send" or  "MSG" command are used to send a message from host computer to another computer in network.
It is received in the form of pop up at receiving computer. Although both have same functionality, the only difference is that "Net Send" command was deprecated from Windows XP SP2 onwards, replacing it by "MSG" command.
In the UI there is "Directory Entry" which shows list of all the name of computers currently connected on the network. This does not show any device apart from the computer, on clicking any of the computer name it will display its IP address on the text box adjustant to it. <br/>
Below is a text box that takes any input as string, which is the message to transmitted. Next to it are two buttons "Send" & "Send All".
The "Send" button sends the message only to the selected IP or name of computer, whereas "Send All" sends the message to all the computer/IP in the directory.

3. Locking Drives....

When we talk about drives with names "C:" or "D:" or "E:", we are actually, giving names to the part or section of physical hard disk, Each hard drive has atleast one partition to be used by operating system but we can create more as well. Usually in Windows Operating system, one partition(Usually C:) is gievn to the operating system for its own file storage, whereas other are used by user for his/her storage purpose. We may keep our important documents, or even some of our personal pic, videos etc. <br/> <br/>
In the opening of U.I, a simple button which says "ACCESS" appears, which on click brings the real interface in front, There are two list boxes, one contains name of partition in our computer whereas other contains information about them. These information include file system, free space and available space.<br/>
To lock a particular drive simply select your drive name and click on lock button below, the drive will be locked and will not be opened on click as usual. (Note that it is not password based protection but will actually take permissions from the user), To unlock it simply select the locked drive and click on "Unlock button".
*This module is still not complete and safe method to use, one is requested not to use on the drive where the operating system is installed.

4. Folder Drives....

Folder are virtual locations used to store computer data, almost every operating system has the folder utility. 
It works same as "Drive Lock", one need to click on "Browse" button and select the folder to be locked, then the path will appear in the text box. Click on the lock button to securely lock it. To unlock it, simply click on browse button, select the folder that it is locked and click on "Unlock" button.
*  Just like "Lock Drive" it is advised not to lock any files that are used by the operating system, like (program file, system files etc.).

5. SysKey....

SysKey was first introduced in "Windows NT 4.0 SP3", it is used to encrypt hashed password information in the Windows Registry. It can also be configured to require to require the user to enter the key at boot time or as start up password. 
In the U.I. on the clicking the "Execute" button it will call upon the SysKey utility, from where you select the "Encryption Enabled", followed by typing the password in the text box.
It will require a reboot and once done you will notice password protection after boot up and before startup.

6. Encrypting/Decrypting....

Encryption is one of the most effective ways to achieve "Data Security", converting text to a secret format that is not readable form is way to achieve encryption. One needs to have a secret key to encrypt data and same for decrypting it.
Select the file you wish to encrypt using the browse button, then select the destination where you wish to keep the encrypted file. Once done enter the secret key in the text box below it and re-conform the password in the text box below to that and press "Encrypt" button.
It will replace the old file with a new file with extension '. encrypt'. If you try to open it with any of your editor it will be shown as a data which is not edible.
To decrypt the file, simply go to the "Decryption" Panel and browse the encrypted file, add the secret key you used to encrypt the file and press "Decrypt". The encrypted file will be back to the original format.

7. File Combining.... 

Copy is a universally accepted method to transfer one file to another, either in Windows, Mac or Linux. It copies files from one destination to another But it can be used for data security as well (I know it sounds a bit weird, but you will love it). When a two files with copy command are combined and transferred to a new destination with another file name, then the resulting file will have the content as combined with two.
To use the module Click on "Browse" button and select the first file you wish to replace, then click on "Add" button the file will be added in the list box below. To add another file, click on "Browse" button again, select the file and click on "Add" button. Repeat this 'n' no. of times.
When all your files are added, enter a file name in the text box below and from the drop down box next to it select the extension type (which can either be .Txt, .mp3, .JPG, .PNG, .GIF). Click on "Execute" button. A new file name with extension as entered will appear on the path chosen. 
You may notice that the file may have the extension as selected, but with it won't behave as it, instead it will behave as the files added in the list.
If the files added are of different extension, then the behavior may vary, but if the extensions are same the result may come up as expected.

8. File Hiding....

It works on the same fundamentals as "File Combining" above, it uses the copy command but in a slightly different manner. Instead of creating a new file it will hide one file in another. 
Select the files from the browse button one at a time and click on "Add" each time, they will be added in the list box below. 
Then, select the file which you wish to replace with the new files from "Browse" button, click on "EXECUTE" the file will be replaced with the files selected in list keeping the structure safe.

9. 
