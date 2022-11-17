SELECT * FROM sql10527490.customer;

DELETE FROM customer WHERE idCustomer = (SELECT idCustomer FROM (SELECT idCustomer FROM customer
									WHERE email = 'pamela@gmail.com') AS GetCustomerID)
;

