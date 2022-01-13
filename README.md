# Musical Instrument Shop RESTful API

## Deployment

Project Deployed at https://instrumentshop.herokuapp.com

## Routes

**GET /api/instruments** - Returns a list of all instruments

Returns:

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

Returns:

    {
    "id": 1,
    "name": "French Horn",
    "family": "Brass",
    "price": 12999.99
    }

**POST /api/isntruments** - Create a new instrument

Example Request Body:

    {
        "name" : "Tuba,
        "family" : "Brass",
        "price" : 3496.43
    }

Returns:

    {
    "id": 5,
    "name" : "Tuba,
    "family" : "Brass",
    "price" : 3496.43
    }

**PUT /api/instruments/{id}** - Updates an existing instrument by Id

Example Request Body:

    {
        "name" : "Tuba,
        "family" : "Brass",
        "price" : 9943.43
    }

Returns 204 No Content

**PATCH /api/instruments/{id}** - Partially updates an existing instrument by ID per guidelines on http://jsonpatch.com/

Example Request Body:

    [
        {
            "op": "replace",
            "path": "price",
            "value": 200.00
        }
    ]

Returns 204 No Content

**DELETE /api/instruments{id}** - Deletes an existing instrument

Returns 204 No Content
