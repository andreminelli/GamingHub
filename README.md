 **This is a work in progress!!**

This repo is a playground for testing existing approaches for microservices implementations on .Net. 
Each folder has a complete solution using one of the following approaches:

- [ ] HTTP API (using ASP.Net Core + OpenAPI) (started)
- [ ] gRPC (using [protobuf-net.Grpc](https://protobuf-net.github.io/) - aka "code first gRPC") (started)
- [ ] [Dapr](https://dapr.io) (using Dapr 1.0-rc3) (started)
- [ ] [Microdot](https://github.com/gigya/microdot)
- [ ] [Service Fabric](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-overview)
- [ ] [MS Orleans](https://dotnet.github.io/orleans/) (an actory system, which could be thougth as a more granular microservice approach)

### (Proposed) Service Arquitecture

A game lobby for online game playing. Only a single game - TicTacToe - will be available, with a text-based console interface for interacting with it.

[Architecture Diagram](http://dreampuf.github.io/GraphvizOnline/#digraph%20architecture%20%7B%0D%0A%20%20rankdir%3DLR%3B%0D%0A%0D%0A%20%20%2F%2F%20Storage%20-%20%23303F9F%20(dark%20blue)%0D%0A%20%20node%5Bfillcolor%3D%22%23303F9F%22%20style%3D%22filled%22%20fontcolor%3D%22white%22%5D%3B%0D%0A%20%20database%5Blabel%3D%22DB%22%5D%3B%20cache%5Blabel%3D%22Redis%22%5D%3B%0D%0A%20%20%0D%0A%20%20%2F%2F%20Client-side%20Apps%20-%20%23FFEB3B%20(yellow)%0D%0A%20%20node%5Bfillcolor%3D%22%23FFEB3B%22%20style%3D%22filled%22%20fontcolor%3D%22black%22%5D%3B%0D%0A%20%20console_end%5Blabel%3D%22Console%20App%22%5D%3B%0D%0A%20%20%0D%0A%20%20%2F%2F%20Microservices%20-%20%23C8E6C9%20(light%20green)%0D%0A%20%20node%5Bfillcolor%3D%22%23C8E6C9%22%20style%3D%22filled%22%20fontcolor%3D%22black%22%5D%3B%0D%0A%20%20account_ms%5Blabel%3D%22User%20MS%22%5D%3B%20gamelobby_ms%5Blabel%3D%22GameLobby%20MS%22%5D%3B%20game1_ms%5Blabel%3D%22TicTacToe%20MS%22%5D%3B%0D%0A%20%20%0D%0A%20%20%2F%2F%20API%20Gateways%20-%20%23FFCCBC%20(light%20orange)%0D%0A%20%20node%5Bfillcolor%3D%22%23FFCCBC%22%20style%3D%22filled%22%20fontcolor%3D%22black%22%5D%3B%0D%0A%20%20my_app_api%5Blabel%3D%22Main%20API%22%5D%3B%0D%0A%20%20%0D%0A%20%20subgraph%20client_side_apps%20%7B%0D%0A%20%20%20%20%20%20console_end%20-%3E%20%7Bmy_app_api%7D%3B%0D%0A%0D%0A%20%20%20%20%20%20%7Brank%3Dsame%3B%20console_end%7D%3B%0D%0A%20%20%7D%0D%0A%20%20%0D%0A%20%20subgraph%20api_gateways%20%7B%0D%0A%20%20%20%20%20%20my_app_api%20-%3E%20%7Baccount_ms%2C%20gamelobby_ms%2C%20game1_ms%7D%3B%0D%0A%20%20%7D%0D%0A%20%20%0D%0A%20%20subgraph%20microservices%20%7B%0D%0A%20%20%20%20%20%20node%20%5B%5D%20game1_ms%3B%0D%0A%20%20%20%20%20%20node%20%5B%5D%20account_ms%3B%0D%0A%20%20%20%20%20%20node%20%5B%5D%20gamelobby_ms%3B%0D%0A%20%7D%0D%0A%20%0D%0A%20game1_ms%20-%3E%20%7Bcache%7D%3B%0D%0A%20account_ms%20-%3E%20%7Bdatabase%7D%3B%0D%0A%20gamelobby_ms%20-%3E%20%7Bdatabase%7D%3B%0D%0A%7D)

- [ ] User microservice (started)
- [ ] GameLobby microservice
- [ ] TicTacToe microservice
- [ ] Console application (started)
