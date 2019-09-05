# Project - Plant-A-Plant

## Type - Garden Helper

## Description

This is a simple Garden Helper project which 
will help you to grown flowers, vegetables, fruits, etc.
Guest Users can register and login to their accounts.
Guest Users can only view what the site offers as a service.
Regular Users can create a new event such as (Add a new field with plants).
Regular Users can add new activities to their Event(field).
Regular Users can look up the details in future for activities chronology in their Event(field).
The project also supports Administration. 
Administrators have all rights a Regular User has.
Administrators can also add, edit or delete new flowers, pests, fields.

## Entities

### User
  - Id (string)
  - Username (string)
  - Password (string)
  - Email (string)
### Event
  - Id (string)
  - Field (Field)
  - Plants (List of Plants)
  - RegisteredOn (DateTime)
  - User (User)
### Field
  - Id (string)
  - Location (string)
  - Soil (enum of Soil Types)
  - Plants (List of Plants)
  - Activities (List of Activities)
### RegisterActivity
  - Id (string)
  - Description (string)
  - RegisteredOn (DateTime)
  - Field (Field)
### Plant
  - Id (string)
  - Name (string)
  - EstimatedTimeForGrowing (TimeSpan)
  - Family (Family)
  - PlantsPests (List of PlantsPests)
### Family
  - Id (string)
  - Description (string)
  - Plants (List of Plants)
### Pest
  - Id (string)
  - Type (PestType)
  - PestsPlants (List of PestsPlants)
### PestType
  - Id (string)
  - Name (string)
  - Description (string)
  - Pests (List of Pests)
### PestsPlants - Mapping Table
  - Id (string)
  - Pest (Pest)
  - Plant (Plant)