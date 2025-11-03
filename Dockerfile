# ✅ True positives
ENV API_KEY=example
ARG BUILD_ENV=production
ARG BUILD_KEY=preproduction

# ❌ False positives
RUN echo "true" && echo "none"
