/*1) find the names, street address and cities of residence foe all employees who work for" first bank corporation" and earn more than $10,000 */
SELECT e.ename, e.address, e.city
FROM employee e, works w, company c
WHERE e.ssn = w.essn AND w.cname = c.cname AND c.cname = 'first bank corporation' AND w.salary > 10000;

