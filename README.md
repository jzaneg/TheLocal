# The Local
## Application Specifiacations and Change Log

##### Title: The Local 
##### Author: Zane Garner
##### Begin Date: Apr-2019

___ 
Table of Contents
---
##### 1. Introduction
- 1.1 Purpose
- 1.2 Intended Audience

##### 2. Overall Description
- 2.1 Description
- 2.2 Features

##### 3. Application Features
- 3.1 Primary Features and uses

##### 4. Change Log
- 4.1 Project Phases
- 4.2 History of changes

##### 5. Future Improvements
- 5.1 Future Improvements

---
#### 1. *Introduction*
##### 1.1 Purpose
The application is designed to help users connect with their local communities by discovering and engaging in local establishments while providing new and exciting experiences. Built using C#, ASP.NET, MVC, HTML, CSS, and JS.
##### 1.2 Intended Audience
The intended audience is for all users. 
##### 1.3 Project Scope
The scope of the project is to create a seamless, fluid, and easy to use interface to provide the best user experience possible. Google Maps API is heavily involved to expand upon recongnizable features while providing new experiences.

---
#### 2 *Overrall Description*
##### 2.1 The Local Description
The Local is an application which helps users identify locations and establishments in the local community to engage in new experiences and opportunities. Travelers will also find this application useful to find great places to spend time that otherwise might not have been identified otherwise. Providing a seamless and user obsessed experience, users can spend more time enjoying new places and experiences and less time finding them.

##### 2.2 Features
Current phase features are intended to include a responsive UI with stable backend to support smooth and fluid user interaction. Google Maps API, Customizeable user maps, and guest features are all included in the current version.

---
#### 3. Application Features
##### 3.1 Primary Features and Uses
- Primary features include allowing registered users to create a custom map with locations that they have identified and saved, populating their map with these locaitons.
- Guest are able to view locations that registered users have identified and saved, encouraging them to become a part of the community.
---
#### 4. *Change Log*
##### 4.1 Project Phases


##### 4.2 Change Log
- MAR-2019 | Begin coding backend DB.
- MAR-2019 | Completed DB tables.
- MAR-2019 | Begin implementing .NET Identity for user authentication/registration.
- MAR-2019 | Created registered user page. 
- MAR-2019 SUMMARY
  * Found bug with primary/foriegn keys amongst identity and DB tables.
  * Switched to .NET Core from .NET Framework.
  * Registered and began looking into implementing Google Maps API.
- APR-2019 | Began implementing Google Maps API to dispaly locations on user and guest maps.
- APR-2019 | Began working on controllers for adding/saving/deleting locations to DB.
- APR-2019 | Working with JS to script out adding markers and populating maps with DB locations.
- APR-2019 | Adding modals to update/add locations to make page loading/multiple pages at a minimum.
  * Google Maps API and moadls JS conflicting with MVC.
  * Fixed bugs in adding markers.
  * Still need to fix sizing and layout.
- MAY-2019 | No noteable changes / shifted to other projects.
- JUN-2019 | Fixed DB issues with loading data to modals from DB.
- JUN-2019 | Fixed modal loading issues on guest page from DB.
- JUN-2019 | Cleaned Google Maps API JS additional features added
  * Need to seperate JS file from Logged In User page.
  * Need to add Update/Delete buttons to users modal.
  * Need to fix guest map sizing issue.
  * Need to implement mobile sizing features/fixes.

---
#### 5. Future Improvements
##### 5.1 Future Improvements
- Current planned future improvements include:
  * Tying in establishment schedules/events to registered users saved markers.
  * Adding calendar feature to send alert if saved locations are holding events.
  * Adding 'friends' feature to be able to add users to see their favorite spots.
  * Two-Factor authentication for better security.

