# PomarColheitaAPI

## Documentação API

 Este projeto é uma API referente a um pomar que precisa catalogar suas platas, espécies, mantendo o histórico da colheita.



{
    "openapi": "3.0.1",
    "info": {
        "title": "Pomar Colheita Api",
        "version": "v2"
    },
    "paths": {
        "/grouptrees": {
            "get": {
                "tags": [
                    "GroupTrees"
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/GroupTrees"
                                    }
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/GroupTrees"
                                    }
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/GroupTrees"
                                    }
                                }
                            }
                        }
                    }
                }
            },
            "post": {
                "tags": [
                    "GroupTrees"
                ],
                "requestBody": {
                    "content": {
                        "application/json": {
                            "schema": {
                                "$ref": "#/components/schemas/GroupTrees"
                            }
                        },
                        "text/json": {
                            "schema": {
                                "$ref": "#/components/schemas/GroupTrees"
                            }
                        },
                        "application/*+json": {
                            "schema": {
                                "$ref": "#/components/schemas/GroupTrees"
                            }
                        }
                    }
                },
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/GroupTrees"
                                    }
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/GroupTrees"
                                    }
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/GroupTrees"
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        "/grouptrees/{id}": {
            "get": {
                "tags": [
                    "GroupTrees"
                ],
                "parameters": [
                    {
                        "name": "id",
                        "in": "path",
                        "required": true,
                        "schema": {
                            "type": "integer",
                            "format": "int32"
                        }
                    }
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "$ref": "#/components/schemas/GroupTrees"
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "$ref": "#/components/schemas/GroupTrees"
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "$ref": "#/components/schemas/GroupTrees"
                                }
                            }
                        }
                    }
                }
            }
        },
        "/harvest": {
            "get": {
                "tags": [
                    "Harvest"
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Harvest"
                                    }
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Harvest"
                                    }
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Harvest"
                                    }
                                }
                            }
                        }
                    }
                }
            },
            "post": {
                "tags": [
                    "Harvest"
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "$ref": "#/components/schemas/Harvest"
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "$ref": "#/components/schemas/Harvest"
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "$ref": "#/components/schemas/Harvest"
                                }
                            }
                        }
                    }
                }
            }
        },
        "/harvest/trees": {
            "get": {
                "tags": [
                    "Harvest"
                ],
                "parameters": [
                    {
                        "name": "id",
                        "in": "query",
                        "schema": {
                            "type": "integer",
                            "format": "int32"
                        }
                    }
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Harvest"
                                    }
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Harvest"
                                    }
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Harvest"
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        "/species": {
            "get": {
                "tags": [
                    "Species"
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Species"
                                    }
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Species"
                                    }
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Species"
                                    }
                                }
                            }
                        }
                    }
                }
            },
            "post": {
                "tags": [
                    "Species"
                ],
                "requestBody": {
                    "content": {
                        "application/json": {
                            "schema": {
                                "$ref": "#/components/schemas/Species"
                            }
                        },
                        "text/json": {
                            "schema": {
                                "$ref": "#/components/schemas/Species"
                            }
                        },
                        "application/*+json": {
                            "schema": {
                                "$ref": "#/components/schemas/Species"
                            }
                        }
                    }
                },
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Species"
                                    }
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Species"
                                    }
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Species"
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        "/species/{id}": {
            "get": {
                "tags": [
                    "Species"
                ],
                "parameters": [
                    {
                        "name": "id",
                        "in": "path",
                        "required": true,
                        "schema": {
                            "type": "integer",
                            "format": "int32"
                        }
                    }
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "$ref": "#/components/schemas/Species"
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "$ref": "#/components/schemas/Species"
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "$ref": "#/components/schemas/Species"
                                }
                            }
                        }
                    }
                }
            }
        },
        "/trees": {
            "get": {
                "tags": [
                    "Tree"
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Trees"
                                    }
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Trees"
                                    }
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Trees"
                                    }
                                }
                            }
                        }
                    }
                }
            },
            "post": {
                "tags": [
                    "Tree"
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "$ref": "#/components/schemas/Trees"
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "$ref": "#/components/schemas/Trees"
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "$ref": "#/components/schemas/Trees"
                                }
                            }
                        }
                    }
                }
            }
        },
        "/trees/species": {
            "get": {
                "tags": [
                    "Tree"
                ],
                "parameters": [
                    {
                        "name": "id",
                        "in": "query",
                        "schema": {
                            "type": "integer",
                            "format": "int32"
                        }
                    }
                ],
                "responses": {
                    "200": {
                        "description": "Success",
                        "content": {
                            "text/plain": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Trees"
                                    }
                                }
                            },
                            "application/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Trees"
                                    }
                                }
                            },
                            "text/json": {
                                "schema": {
                                    "type": "array",
                                    "items": {
                                        "$ref": "#/components/schemas/Trees"
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    },
    "components": {
        "schemas": {
            "GroupTrees": {
                "required": [
                    "description",
                    "name",
                    "trees"
                ],
                "type": "object",
                "properties": {
                    "code": {
                        "type": "integer",
                        "format": "int32"
                    },
                    "name": {
                        "type": "string"
                    },
                    "description": {
                        "type": "string"
                    },
                    "trees": {
                        "type": "string"
                    }
                },
                "additionalProperties": false
            },
            "Harvest": {
                "required": [
                    "grossWeight",
                    "harvestDate",
                    "information",
                    "treeId"
                ],
                "type": "object",
                "properties": {
                    "id": {
                        "type": "integer",
                        "format": "int32"
                    },
                    "information": {
                        "type": "string"
                    },
                    "harvestDate": {
                        "type": "integer",
                        "format": "int32"
                    },
                    "grossWeight": {
                        "type": "number",
                        "format": "double"
                    },
                    "treeId": {
                        "type": "string"
                    },
                    "trees": {
                        "$ref": "#/components/schemas/Trees"
                    }
                },
                "additionalProperties": false
            },
            "Species": {
                "required": [
                    "description"
                ],
                "type": "object",
                "properties": {
                    "code": {
                        "type": "integer",
                        "format": "int32"
                    },
                    "description": {
                        "maxLength": 60,
                        "minLength": 3,
                        "type": "string"
                    }
                },
                "additionalProperties": false
            },
            "Trees": {
                "required": [
                    "age",
                    "description",
                    "speciesId"
                ],
                "type": "object",
                "properties": {
                    "code": {
                        "type": "integer",
                        "format": "int32"
                    },
                    "description": {
                        "maxLength": 500,
                        "type": "string"
                    },
                    "age": {
                        "type": "integer",
                        "format": "int32"
                    },
                    "speciesId": {
                        "type": "integer",
                        "format": "int32"
                    },
                    "species": {
                        "$ref": "#/components/schemas/Species"
                    }
                },
                "additionalProperties": false
            }
        }
    }
}
