# Mayden Coding Challenge

Trello Board Used
https://trello.com/b/a9uDsABY/mayden-coding-challenge

Time used
![Time Used Image](https://github.com/TheNerdMan/MaydenCodingChallenge/blob/master/totalTimeUsed.png?raw=true)

Bellow is the PDF sent by Mayden

# Mayden Developer Recruitment

# Coding Challenge

Rules

Things We’re Looking For

Overview

Stories

API Information

## Rules

```
● Agree the number of hours you can commit to (up to 6) and select the number of
stories you feel like you can achieve within this time.
● Commit the code to a public repository.
● Don’t worry about using our tech stack, use a stack you’re comfortable with.
● Please email a link to your repository within a week of receiving the challenge.
● Any questions, please email: ​recruitment@mayden.co.uk​.
```
## Things We’re Looking For

We’re looking for well structured, secure and clean code that is adequately tested.

## Overview

As a healthcare company we have a keen eye on healthy eating and it’s been suggested by
an employee that we have an easy way to keep track of what we need, what needs to be
purchased and keep spending within the budget constraints. Below, are a number of stories
which will achieve this objective.

## Stories

1. View a list of items on a shopping list
    **As a ...** ​Shopper
    **I want to ...** ​View items on my shopping list
    **So I can ...** ​ See what I have chosen to purchase


```
Requirements:
Create a shopping list that can contain a list of groceries
```
2. Add items to the shopping list

```
As a ... ​Shopper
I want to ... ​be able to add items to my shopping list
So I can ... ​ Add new items to my shopping list that don’t already exist on it
```
```
Requirements
Create a way for a user to add an item to the shopping list
```
3. Remove stuff from the shopping list

```
As a ... ​shopper
I want to ... ​be able to remove items from my shopping list
So I can ... ​ Change my mind or fix my mistakes
```
```
Requirements
Create a way for user to remove an item to the shopping list
```
4. When I’ve bought something from my list I want to be able to cross it off the list

```
As a ... ​shopper
I want to ... ​have a way of marking off when I’ve picked up an item
So I can ... ​ see what I still need to find
```
```
Requirements
Create a way for users to know what they have and haven’t already picked up
```
5. Persist the data so I can view the list if I move away from the page

```
As a ... ​shopper
I want to ... ​be able to still see the state of my shopping list when I come back to it
So I can ... ​ still see the items I’ve added and marked off when I get to the supermarket
```
```
Requirements
Persist shopping list state between page visits
```
6. I want to be able to reorder items on my list


```
As a ... ​shopper
I want to ... ​be able to reorder items on my shopping list
So I can ... ​ maintain my supermarket route when the supermarket swaps things around
on it’s shelves
```
```
Requirements
Create a way for user to be able to change the order of items in their shopping list
```
7. Use an API to fetch prices on the list

```
As a ... ​shopper
I want to ... ​see how much each item on my list are going to cost me
So I can ... ​ effectively manage my shopping budget
```
```
Requirements
Use the ​API information​ at the bottom of this page to look up the cost of items on the
shopping list, display the cost of each item in the shopping list
```
8. Total up the prices

```
As a ... ​shopper
I want to ... ​see the total of how much the items on my list are going to cost me
So I can ... ​ quickly see whether my shop is in budget
```
```
Requirements
Display the total cost for the whole shop
```
9. Put a spending limit in place, alert me if I go over the limit

```
As a ... ​shopper
I want to ... ​see the total of how much the items on my list are going to cost me
So I can ... ​ quickly see whether my shop is in budget
```
```
Requirements
Display the total cost for the whole shop
```
10.I want to share my shopping list via email

```
As a ... ​shopper
I want to ... ​I want to send my shopping list to my partner
So I can ... ​ shop instead of me
```

```
Requirements
Add functionality to send the shopping list via email
```
```
11.User and password protect
As a ... ​shopper
I want to ... ​protect my shopping list from other people
So I can ... ​ be sure it’s unchanged when I go back to it
```
```
Requirements
Add a login system to persist shopping lists for different users
```
## API Information

Tesco API information:
Subscription Key: ca58f691ff944fd59a27347a944d

Example URL:
https://dev.tescolabs.com/grocery/products/?query=quorn&offset=0&limit=

```
<?php
​// This sample uses the Apache HTTP client from HTTP Components
(http://hc.apache.org/httpcomponents-client-ga/)
​require_once​ ​'HTTP/Request2.php'​;
```
```
$request = ​new
Http_Request2(​'https://dev.tescolabs.com/grocery/products/?query={query}
&offset={offset}&limit={limit}'​);
$url = $request->getUrl();
```
```
$headers = ​array​(
​// Request headers
​'Ocp-Apim-Subscription-Key'​ => ​'{subscription key}'​,
);
```
```
$request->setHeader($headers);
```
```
$parameters = ​array​(
​// Request parameters
);
```
```
$url->setQueryVariables($parameters);
```
```
$request->setMethod(HTTP_Request2::METHOD_GET);
```

// Request body
$request->setBody(​"{body}"​);

try
{
$response = $request->send();
​echo​ $response->getBody();
}
catch​ (HttpException $ex)
{
​echo​ $ex;
}


