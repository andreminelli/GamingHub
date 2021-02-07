## Pre-requirements
Dapr 1.0-rc3

## Running

All services must run 'inside' Dapr runtime (even the ones that are just 'clients') so they could properly communicate with each other using Dapr API.

* Go to UserService project folder and execute run.bat
* Go to GameConsoleApp project folder and execute run.bat

## Limitations
- Can't debug Dapr runtime inside VS, yet...