# KoinonikosTourismos
This is a simple MVC app that search if the user is selected, runner up, or rejected for the program of Koinonikos Tourismos.
I had to look myself up using the .xlsx files and I really didn't had any fun. I thought I could make the user experience slightly better by making this app.
Feel free to contact me for further info.

## Data Preparation
First I downloaded the data provided from [DYPA](https://www.dypa.gov.gr/koinonikos-toyrismos?tab=koinonikos-toyrismos-2023-2024&tab2=oristika-apotelesmata&tab3=dikaioukhoi).
I downloaded the CSV files provided and I created a database locally using MS SQL Server. I used the **Import from Flat File** tool.
Furthermore, since the original data were in a CSV format, I had to make some changes to the tables and add an extra Id column.

## How It Works
It's just a simple form that the User can input their *Vat Number* and *Social Security Number*. Upon form submission a query is executed against the selected people table. If no results found, the following logic is performed:

```C#
if (selected == null)
{
    runnerUp = GetSingleOrDefaultFor<RunnerUp>(vatNumber4digits, socialSecurityNumber4digits);
    if (runnerUp == null)
    {
        rejected = GetSingleOrDefaultFor<Rejected>(vatNumber4digits, socialSecurityNumber4digits);
    }
}
```
Then the data is passed on to the View where the appropriate partial view gets rendered.

