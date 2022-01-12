# Musical Instrument Shop API

## Routes

**GET /api/instruments** - Returns a list of all instruments

    [
        {
        "id": 1,
        "name": "French Horn",
        "family": "Brass",
        "price": 12999.99
        },
        {
        "id": 2,
        "name": "Trumpet",
        "family": "Brass",
        "price": 999.99
        },
        {
        "id": 3,
        "name": "Trombone",
        "family": "Brass",
        "price": 1999.99
        },
        {
        "id": 4,
        "name": "Violin",
        "family": "String",
        "price": 99999.64
        }
    ]

**GET /api/instrument/{id}** - Returns an instrument by ID

    {
    "id": 1,
    "name": "French Horn",
    "family": "Brass",
    "price": 12999.99
    }

## Deployment

To deploy locally (dotnet required), you need to clone the repository and then initiate dotnet run.

    git clone https://github.com/philipbrowne/ASP.NET-Instrument-Shop
    dotnet run

Then open http://localhost:5243/api/instruments
