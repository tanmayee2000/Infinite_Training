create database Mini_Project
use Mini_Project

--ADMIN TABLE
Create Table Admin (
    AdminId Int Primary Key,
    Username NVarchar(50),
    Password NVarchar(50)
)

Insert into Admin Values
(1, 'Admin', 12345)

-----------------------------------------------------------------------

--USERS TABLE
Create Table [User] (
    UserId Int Primary Key,
    Username NVarchar(50) UNIQUE,
    Password NVarchar(50)
)

Insert into [User] Values
(1, 'Tanmayee', 'tani123'),
(2, 'Jahnavi', 'jan123')

------------------------------------------------------------------------------

--TRAIN TABLE
Create Table Trains (
    TrainNo Int Primary Key,
    TrainName NVarchar(50),
    FromStation NVarchar(50),
    ToStation NVarchar(50),
    ClassOfTravel NVarchar(10),
    SeatsAvailable Int,
    Status NVarchar(10),
    TrainStatus NVarchar(10)
)

INSERT INTO Trains (TrainNo, TrainName, FromStation, ToStation, ClassOfTravel, SeatsAvailable, Status, TrainStatus)
VALUES
(12705, 'VandeBharath', 'Chennai', 'Bangalore', 'AC/Sleeper', 120, 'Inactive', 'On-Time'),
(14522, 'Rajdhani exp', 'Bangalore', 'Delhi', 'AC/Sleeper', 30, 'Active', 'Delayed'),
(12214, 'Shatabdi exp', 'Delhi', 'Mumbai', 'AC/Sleeper', 54, 'Active', 'On-Time')

----------------------------------------------------------------------------------------------------------------------

--BOOKING TABLE
Create Table Bookings (
    BookingId Int Primary Key Identity,
    UserId Int,
    TrainNo Int,
    ClassOfTravel NVarchar(10),
	DateOfJourney Date,
    PriceOfTicket Decimal(10, 2),
    Gender NVarchar(10),
    SeniorCitizenQuota NVarchar(3),
    SeatsBooked Int,
    FOREIGN KEY (UserId) REFERENCES [User](UserId),
    FOREIGN KEY (TrainNo) REFERENCES Trains(TrainNo)
)

----------------------------------------------------------------------------

--CANCELLATIONS TABLE
Create Table Cancellations (
    CancellationId Int Primary Key Identity,
    BookingId Int,
    CancellationDate DATE,
    FOREIGN KEY (BookingId) REFERENCES Bookings(BookingId)
)

-----------------------------------------------------------------------------

Select * from Admin
Select * from [User]
Select * from Trains
Select * from Bookings
Select * from Cancellations

-----------------------------------------------------------------------------