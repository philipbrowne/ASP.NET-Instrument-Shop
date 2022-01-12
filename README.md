# Musical Instrument Shop RESTful API

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

**POST /api/isntruments** - Create a new instrument

    {
        "name" : "Tuba,
        "family" : "Brass",
        "price" : 3496.43
    }

    Returns

    {
    "id": 5,
    "name" : "Tuba,
    "family" : "Brass",
    "price" : 3496.43
    }
