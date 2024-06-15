Term Project - Personal Organization Application

The user needs a personal organizer application which can be used by multiple users. 
The application includes a phonebook, notes, personal information, reminders on the 
calendar and a salary calculator. Hold data for each module in a separate CSV, TXT or 
XLSX file but do not forget to link a phone record and its owner who is stored in the user 
file. 

Tasks;

User Management

▪ First registered user will be the administrator of the system.
▪ Other users will be normal users.
▪ Admin could change user type. User types: Admin, user, part-time-user.
o Create a user management window and give access to only admin users.

Phone Book

▪ A detailed phone book will be created. (name, surname, phone number, address, 
description, e-mail) 
o List records
o Create a record
o Update a record
o Delete a record
▪ Store data in the “phonebook.csv” (It can also be in txt or xlsx format)
▪ Fields on the window need to accept only needed format such as number fields 
accepts only numbers. The phone number needs formatted like (555) 555 55 55.
▪ Verify that the text entered in the E-mail field is a valid e-mail. (Tip: 
RegEx(Regular Expression) may help you)

Notes

▪ A simple note list will be created.
▪ Notes module has only one field.
▪ Store data in the “notes.csv” (It can also be in txt or xlsx format)
▪ User may enter more than one note so the user needs below use cases.
o List notes
o Create a note
o Update a note
o Delete a note

Personal Information

▪ User needs to view and edit his/her profile. The profile page will have user 
information (name, surname, phone number, address, e-mail, password, photo)
▪ User needs to change the password and other information from the profile 
screen.
▪ Store photo in CSV file as base64 format.
▪ CTRL – Z & CTRL – Y capability on user profile window. (Memento)
o Each field changes need to manage via CTRL-Z to undo and CTRL-Y to redo.

Salary Calculator

▪ According to BMO, a staff’s minimum salary should be calculated via some 
parameters1,2
o Create a screen to calculate the user’s minimum salary and hold this information 
as user information.
▪ Read BMO rules carefully and hide fields if they are not needed otherwise 
show them.
o User needs to enter/update these data.
o On the profile screen, you need to show the calculated salary. The minimum 
salary will be calculated as %50 off for the part-time user.

Reminder

o User need to manage (list, add, update, delete) reminders
▪ There are two reminder types (meeting & task) (Abstract Factory)
o Each reminder has a date, time, summary and description fields.
o The reminder will show summary value on active windows header and 
shake active windows along two seconds. (Observer)
