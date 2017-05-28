# Problem Specification



## Overview

Create a simple room reservation system. The project includes management of different resources such as `Users` and `Rooms`, and capability to `Reserve a room`.



## Requirements

### Management



#### Rooms

The application should have self management and maintenance for Rooms. It should have the capability to make a new room, set it's availability for reservation, define the facilities, floor located and capacity.



The management functionality is only available to `Room Administrators`.



#### Users

Users can perform room reservations. The system should be able to authenticate a user to avoid reservation tampering. The user should have basic identity information and have an email so we can have a way to confirm the user.



### Room Reservation



#### Reservation

##### Check for available room

An user should be able to view room's schedule depending on the `selected day`. A reservation should contain a title, duration, and the person who reserved the room. It should also have an identification to quickly determine what are `Past Reservations`, `Currently Occupying the room`, `Future Reservations`. The room's information, such as facilities, capacity should be displayed as well.



##### Make a reservation

The user can make a reservation by supplying the date and time and title/purpose of reservation. The system should be able to validate based on the following rules.



* Room is active and available for reservations
* No one's occupying the room during the given schedule
* The user has no reservation on different room during the given schedule
* The schedule is not a past date during save

##### Cancel a reservation

The user should be able to cancel his `future` and `on-going` reservation. This is to free up rooms and give others opportunity to book the room.



#### Transaction Footprints

Any changes in the database, or transaction operations should be logged.



### Other Requirements


#### Recommend Quick Reservation

The system can provide quick recommendation just providing the schedule and number of occupants. It should view first the recommendation before you'll be able to save it. The system may also provide another flavors of recommendation such as `Rooms that have projector for 3 pax` or `Rooms that has computers`.


#### Notification

First, the user should be notified if the reservation is confirmed. The system should also be able to have a functionality if the room becomes available on a certain schedule, the user subscribed to that schedule is going to be notified. This however, will not guarantee that his slot is reserved. NOTE: For sending email, you can use `fake smtps` such as `Papercut` or `Smtp4Dev`. 
