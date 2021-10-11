# AzureFunctions-Kennisdeling

## Benodigdheden

* Azure API Management
* Azure Service Bus
* Deployment naar Azure Functions

## Handige links
* Deployment van azure functions app + koppeling met azure api management: https://docs.microsoft.com/en-us/azure/api-management/import-function-app-as-api
* Azure service bus queues: https://www.c-sharpcorner.com/article/how-to-send-read-messages-from-azure-service-bus-queues-using-azure/

## Branches
* step-1-basic-function: een simpele HTTP call naar een azure function
* step-2-queue: twee azure functions die communiceren met een azure service bus

## Belangrijk
Op een gegeven moment verwijder ik de azure service bus die draait op mijn azure portal, m.a.w. als je het wil testen maak je eigen azure service bus en voeg deze regel toe aan je local.settings.json:
"AzureWebJobsServiceBus": {jouw primary connection string}
