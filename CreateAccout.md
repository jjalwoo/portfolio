```mermaid
sequenceDiagram

participant Client
participant CreateAccountServer
participant DB

CreateAccountServer ->> DB: Connect DB!
DB ->> CreateAccountServer: DB Connect Success!
Client ->> CreateAccountServer: AccountPacket!
CreateAccountServer ->> DB: InsertAccount!






