.PHONY: setup
setup:
	docker-compose build

.PHONY: build
build:
	docker-compose build open-search-example

.PHONY: serve
serve:
	docker-compose build open-search-example && docker-compose up open-search-example

.PHONY: shell
shell:
	docker-compose run open-search-example bash

.PHONY: test
test:
	docker-compose up test-database & docker-compose build open-search-example-test && docker-compose up open-search-example-test

.PHONY: lint
lint:
	-dotnet tool install -g dotnet-format
	dotnet tool update -g dotnet-format
	dotnet format

.PHONY: restart-db
restart-db:
	docker stop $$(docker ps -q --filter ancestor=test-database -a)
	-docker rm $$(docker ps -q --filter ancestor=test-database -a)
	docker rmi test-database
	docker-compose up -d test-database
