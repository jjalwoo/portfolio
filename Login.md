```mermaid
sequenceDiagram

participant Client
participant Server
participant DB

Client ->> Server: LoginPacket
Server -> DB: CheckLogin

alt Success
Server->>Client: Token
else Fail
Server->Client: Fail
end
