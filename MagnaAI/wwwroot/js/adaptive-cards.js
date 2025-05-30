// wwwroot/js/adaptive-cards.js
class AdaptiveCardsManager {
    constructor() {
        this.newsServiceUrl = '/api/news'; // Placeholder for future API endpoint
        this.adaptiveCardsContainer = document.getElementById('adaptiveCardsContainer');
    }

    async loadAdaptiveCards() {
        try {
            // Pro testování použijeme statická data
            // V budoucnu zde bude volání na skutečné API
            const testData = this.getTestData();

            for (let i = 0; i < testData.length; i++) {
                await this.renderAdaptiveCard(testData[i], i);
            }
        } catch (error) {
            console.error('Chyba při načítání Adaptive Cards:', error);
            this.showErrorMessage();
        }
    }

    async renderAdaptiveCard(cardData, index) {
        try {
            // Vytvoření adaptivní karty
            const adaptiveCard = new AdaptiveCards.AdaptiveCard();

            // Načtení konfigurace hostConfig
            const hostConfig = await this.loadHostConfig();
            adaptiveCard.hostConfig = new AdaptiveCards.HostConfig(hostConfig);

            // Parsování JSON dat karty
            adaptiveCard.parse(cardData);

            // Vykreslení karty
            const renderedCard = adaptiveCard.render();

            // Vytvoření wrapper elementu
            const cardWrapper = document.createElement('div');
            cardWrapper.className = 'adaptive-card-wrapper';
            cardWrapper.appendChild(renderedCard);

            // Přidání do kontejneru
            if (this.adaptiveCardsContainer) {
                this.adaptiveCardsContainer.appendChild(cardWrapper);
            }

        } catch (error) {
            console.error(`Chyba při vykreslování karty ${index}:`, error);
        }
    }

    async loadHostConfig() {
        try {
            const response = await fetch('/js/adaptivecardstyle.json');
            if (!response.ok) {
                throw new Error('Nepodařilo se načíst konfiguraci adaptivních karet');
            }
            return await response.json();
        } catch (error) {
            console.error('Chyba při načítání hostConfig:', error);
            // Vrátit základní konfiguraci
            return this.getDefaultHostConfig();
        }
    }

    getDefaultHostConfig() {
        return {
            "spacing": {
                "small": 8,
                "default": 16,
                "medium": 24,
                "large": 32,
                "extraLarge": 40
            },
            "fontFamily": "Segoe UI, Tahoma, Geneva, Verdana, sans-serif",
            "fontSizes": {
                "small": 12,
                "default": 14,
                "medium": 16,
                "large": 18,
                "extraLarge": 20
            },
            "containerStyles": {
                "default": {
                    "backgroundColor": "#FFFFFF",
                    "foregroundColors": {
                        "default": {
                            "default": "#000000"
                        }
                    }
                }
            },
            "actions": {
                "buttonSpacing": 8,
                "actionsOrientation": "horizontal"
            }
        };
    }

    getTestData() {
        // Testovací data podle struktury z evýdejky systému
        return [
            {
                "type": "AdaptiveCard",
                "version": "1.3",
                "body": [
                    {
                        "type": "Container",
                        "items": [
                            {
                                "type": "TextBlock",
                                "text": "Aktuální informace",
                                "weight": "Bolder",
                                "size": "Medium",
                                "color": "Accent"
                            },
                            {
                                "type": "TextBlock",
                                "text": "Nová školení AI jsou nyní dostupná pro všechny zaměstnance. Registrace probíhá přes interní portál.",
                                "wrap": true,
                                "spacing": "Small"
                            },
                            {
                                "type": "FactSet",
                                "facts": [
                                    {
                                        "title": "Datum:",
                                        "value": "26. května 2025"
                                    },
                                    {
                                        "title": "Kategorie:",
                                        "value": "Školení"
                                    }
                                ]
                            }
                        ]
                    }
                ],
                "actions": [
                    {
                        "type": "Action.OpenUrl",
                        "title": "Více informací",
                        "url": "https://portal.magna.com/training"
                    }
                ]
            },
            {
                "type": "AdaptiveCard",
                "version": "1.3",
                "body": [
                    {
                        "type": "Container",
                        "items": [
                            {
                                "type": "TextBlock",
                                "text": "Systémová údržba",
                                "weight": "Bolder",
                                "size": "Medium",
                                "color": "Warning"
                            },
                            {
                                "type": "TextBlock",
                                "text": "Plánovaná údržba AI systémů proběhne tento víkend. Očekávané výpadky: 2-4 hodiny.",
                                "wrap": true,
                                "spacing": "Small"
                            },
                            {
                                "type": "FactSet",
                                "facts": [
                                    {
                                        "title": "Datum:",
                                        "value": "31. května 2025"
                                    },
                                    {
                                        "title": "Čas:",
                                        "value": "02:00 - 06:00"
                                    }
                                ]
                            }
                        ]
                    }
                ]
            }
        ];
    }

    showErrorMessage() {
        if (this.adaptiveCardsContainer) {
            this.adaptiveCardsContainer.innerHTML = `
                <div class="error-message" style="text-align: center; padding: 2rem; color: #E22E2F;">
                    <p>Nepodařilo se načíst aktuální informace.</p>
                    <button onclick="location.reload()" class="btn btn-secondary" style="margin-top: 1rem;">
                        Zkusit znovu
                    </button>
                </div>
            `;
        }
    }
}

// Globální funkce pro inicializaci
function loadAdaptiveCards() {
    const manager = new AdaptiveCardsManager();
    manager.loadAdaptiveCards();
}