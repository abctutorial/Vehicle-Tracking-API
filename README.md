# Configuring Project
First Open the project.
Change your server name from appsettings.json.
Go to Package manager console and run **add-migration DBChange**.
If this command not created your tables then run **update-database**.
Put some value in Vehicle table.
# Test API is working
First open postman or any API debuger .
In Headers put Key value is **EfsdDSfsdf343**  .
Use this link to run https://localhost:44396/api/Tracking/1/3.5/3.9 Here first value is vehicle number , second is latitude, third is longtitude.
If you post then value will be save in VehicleTrackingInfo table.
