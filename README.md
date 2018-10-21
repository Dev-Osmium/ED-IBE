# ED-IBE
#### (ED-Intelligent Boardcomputer Extension)  
for Elite Dangerous 

    Trading Tool (local database, no data sharing)
    Commanders Log
    systemdata based on EDDB
    EDSM interface
    E:D Companion interface
    optional connection to EDDN (recieving of marketdata)
    open source

**Installation:**  
Get the latest release from  
	https://github.com/Duke-Jones/ED-IBE/releases.  
The exe file is a installer which guides you through the steps.  

**Forums:**  
on forums.frontier.co.uk (english forum):  
https://forums.frontier.co.uk/showthread.php?t=137732

on elitedangerous.de (deutsches Forum):  
http://www.elitedangerous.de/forum/viewtopic.php?f=66&t=6404&start=0

**License**  
Copyright © 2016 Duke Jones  
Licensed under the [GNU Public License (GPL) v2](https://github.com/Duke-Jones/ED-IBE/blob/master/license/ED-IBE%20license.txt)


*****************************************************************************************
*****************************************************************************************
*****************************************************************************************

#### Needed for development:

- VS2015
- dotNet 4.6 (and 4.6 targeting pack) (http://getdotnet.azurewebsites.net/target-dotnet-platforms.html#)
- MySQL for Visual Studio and MySQL Workbench (over MySQL Installer http://dev.mysql.com/tech-resources/articles/mysql-installer-for-windows.htmlvisual)
- MySQL Connector (manual or also over MySQL Installer)

Establish a data-connection in Visual Studio:  
1) create a new database : start script "create.cmd" in ".\RNDatabase\Database\script\"  
	(leave the second cmd window open - it's the server process).  
   	Datafiles will be created in ".\RNDatabase\Database\data\"  

-  test it with "MySQL Workbench":

   * add a new connection (hostname = localhost, port 3306, username = root, pw = EliteAdmin ).  
     If you can connect everything is fine :-) .  

   * if you open the connection in "MySQL Workbench" you can explorer the data structure,  
     select data from the tables (at the moment most tables are still empty)   
	 and many other things  

   * if you open "\RNDatabase\SQL-Model\Elite_DB.mwb" you see  
     the database structure which is created by "create.cmd" and "create_Elite_DB.sql"    

	 (btw: the content of "create_Elite_DB.sql" comes from "Elite_DB.mwb". Open it and  
	 enter "Database->Forward Engineer", select the connection -> go on with "next" until   
	 "Review the SQL Script to be Executed". Here you can "Copy to Clipboard" and .....   
	 you have the content of the file "create_Elite_DB.sql" :-) )  
	 
2) establish the connection in the VS project  
   * goto Server-Explorer and add a new connection.  
     Select "MySQL Database" ("MySQL for Visual Studio" required) and the set   
	 "Servername = localhost, User=root, pass = EliteAdmin".  
	 Select "elite_db" as database.  
     Thats it - now you can use the structures from the DB in the project.  
        
		
Other hints: 		

*  "start_server.cmd" in ".\RNDatabase\Database\script\"  
   RN starts the db process itself. But you can also start the db process  
   manually by running this script. 

*  if you want to recreate the database from scratch you can use   
   the script "create.cmd" in ".\RNDatabase\Database\script\" again.  
   It will recreate the whole database. All old data will be gone.  

   optional parameters for create.cmd:

   /forceinstall (must be first parameter):  
       don't ask the user for overwriting a existing database (for InnoSetup)  
   &lt;second parameter&gt; (for Innosetup):   
       path to destination directory fpr the data-structure   

   &lt;third parameter&gt; (for Innosetup):   
       path to program directory for acessing the MySQL binaries  
   
   examples:  
     for developing : in a cmd goto script directory and start "create.cmd"  
	 for installer  : create.cmd /forceinstall "F:\ED-IBE" "F:\Program Files\ED-IBE"  
   

*  for creating a installer package use InnoSetup  
