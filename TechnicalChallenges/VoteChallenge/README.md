# Vote Counter 

This challenge requires to consume a REST API GET endpoint which returns a collection of restaurants within a city and an estimated cost.

Example of request:

* * City: Seattle
* Estimated Cost: 110

Example of a response:

> {
  "page": 1,
  "per_page": 10,
  "total": 1,
  "total_pages": 1,
  "data": [
    {
      "city": "Seattle",
      "name": "The Shambles",
      "estimated_cost": 110,
      "user_rating": {
        "average_rating": 4.4,
        "votes": 2116
      },
      "id": 45
    }
  ]
}

Expected result:

* 2116