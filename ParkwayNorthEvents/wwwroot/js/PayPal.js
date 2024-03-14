﻿var form = document.querySelector('#card-form');
var submit = document.querySelector('input[type="submit"]');
var token = document.getElementById('ct').value;
braintree.client.create({
    authorization: token,
}, function (clientErr, clientInstance) {
    if (clientErr) {
        console.error(clientErr);
        return;
    }

    // This example shows Hosted Fields, but you can also use this
    // client instance to create additional components here, such as
    // PayPal or Data Collector.

    braintree.hostedFields.create({
        client: clientInstance,
        styles: {
            'input': {
                'font-size': '14px'
            },
            'input.invalid': {
                'color': 'red'
            },
            'input.valid': {
                'color': 'green'
            }
        },
        fields: {
            number: {
                container: '#card-number',
                placeholder: '4111 1111 1111 1111'
            },
            cvv: {
                container: '#cvv',
                placeholder: '123'
            },
            expirationDate: {
                container: '#expiration-date',
                placeholder: '10/2022'
            }
        }
    }, function (hostedFieldsErr, hostedFieldsInstance) {
        if (hostedFieldsErr) {
            console.error(hostedFieldsErr);
            return;
        }

        submit.removeAttribute('disabled');

        form.addEventListener('submit', function (event) {
            event.preventDefault();

            hostedFieldsInstance.tokenize(function (tokenizeErr, payload) {
                if (tokenizeErr) {
                    console.error(tokenizeErr);
                    return;
                }

                // If this was a real integration, this is where you would
                // send the nonce to your server.
                console.log('Got a nonce: ' + payload.nonce);
            });
        }, false);
    });
});